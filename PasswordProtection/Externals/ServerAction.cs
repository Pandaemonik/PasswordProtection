using System;
using System.Collections;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Threading;

namespace PasswordProtection.Externals
{
    static class ServerAction
    {
        const string serverName = "localhost";
        const int serverPort = 8080;

        const string serverAnswerPattern = @"<SERVER>(?<answer>.*)</SERVER>";
        const string serverHashedPasswordAnswerPattern = "\\<HSHPWD\\>(?<passwordhash>.*)\\</HSHPWD\\>";
        const string eofPattern = "<EOF>$";

        /// <summary>
        /// Wrapper for Regex operations.
        /// It creates a Regex object and performs a match against the given data.
        /// </summary>
        /// <param name="pattern">Regex pattern to be matched</param>
        /// <param name="data">Data/Message to be matched against the regex pattern</param>
        /// <returns>Match object returned by Regex.Match(string)</returns>
        static Match getMatches(string pattern, string data)
        {
            Regex obj = new Regex(pattern);
            return obj.Match(data);
        }

        static bool checkOccurance(string pattern, string data)
        {
            Regex obj = new Regex(pattern);
            return obj.IsMatch(data);
        }

        public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
                return true;

            Console.WriteLine("Certificate error: {0}", sslPolicyErrors);
            return false;
        }

        public static string GetServerSidePass(string Username, string Password)
        {
            var Returnable = string.Empty;
            string message = @"<COMMAND>01</COMMAND>" +// 01 is for Requesting server side password
                             "<USR>" + Username + "</USR>" +
                             "<PWD>" + Password + "</PWD>" +
                             "<EOF>";

            string returnMessage = ConnectToServer(serverName, serverName, message);
            Match statusMatch = getMatches(serverAnswerPattern, returnMessage);
            Match hashedPasswordMatch = getMatches(serverHashedPasswordAnswerPattern, returnMessage);

            if (statusMatch.Success && hashedPasswordMatch.Success && checkOccurance(eofPattern, returnMessage))
            {
                string result = statusMatch.Groups["answer"].Value;
                string hashPasword = hashedPasswordMatch.Groups["passwordhash"].Value;
                if (result.Contains("TRUE"))
                {
                    Returnable = hashPasword;
                }
            }

            return Returnable;
        }

        public static bool IsUsernameInServer(string Username)
        {
            var Returnable = false;

            string message = @"<COMMAND>02</COMMAND>" +// 02 is for checking if username is in the DB
                            "<USR>" + Username + "</USR>" +
                            "<EOF>";

            string returnMessage = ConnectToServer(serverName, serverName, message);
            Match statusMatch = getMatches(serverAnswerPattern, returnMessage);
            if (statusMatch.Success)
            {
                string result = statusMatch.Groups["answer"].Value;
                if (result.Contains("TRUE"))
                    Returnable = true;
            }
            return Returnable;
        }

        public static bool RegisterNewUser(string Username, string Password)
        {
            var Returnable = false;

            string message = @"<COMMAND>03</COMMAND>" +// 03 is for Requesting server side password
                             "<USR>" + Username + "</USR>" +
                             "<PWD>" + Password + "</PWD>" +
                             "<EOF>";

            string returnMessage = ConnectToServer(serverName, serverName, message);
            Match statusMatch = getMatches(serverAnswerPattern, returnMessage);
            if (statusMatch.Success)
            {
                string result = statusMatch.Groups["answer"].Value;
                if (result.Contains("TRUE"))
                    Returnable = true;
            }
            return Returnable;
        }

        public static bool SendPasswordRequest(string Email)
        {
            bool Returnable = false;

            string message = @"<COMMAND>04</COMMAND>" +// 04 is for password reset request
                             "<USR>" + Email + "</USR>" +
                             "<EOF>";

            string returnMessage = ConnectToServer(serverName, serverName, message);
            Match statusMatch = getMatches(serverAnswerPattern, returnMessage);

            if (statusMatch.Success)
            {
                string result = statusMatch.Groups["answer"].Value;
                if (result.Contains("TRUE"))
                    Returnable = true;
            }
            return Returnable;
        }

        public static bool ChangePassword(string Email, string PasswordOld, string PasswordNew)
        {
            bool Returnable = false;
            string message = @"<COMMAND>05</COMMAND>" +// 05 is for password change request
                             "<USR>" + Email + "</USR>" +
                             "<OLDPWD>" + PasswordOld + "</OLDPWD>" +
                             "<NEWPWD>" + PasswordNew + "</NEWPWD>" +
                             "<EOF>";

            string returnMessage = ConnectToServer(serverName, serverName, message);
            Match statusMatch = getMatches(serverAnswerPattern, returnMessage);

            if (statusMatch.Success)
            {
                string result = statusMatch.Groups["answer"].Value;
                if (result.Contains("TRUE"))
                    Returnable = true;
            }

            return Returnable;
        }

        public static bool PingServer()
        {
            return string.Equals(ConnectToServer(serverName, serverName, "ping"), "Pinged");
        }

        public static string ConnectToServer(string machineName, string serverName, string messsageString)
        {
            string serverMessage = string.Empty;
            try
            {
                // Create a TCP/IP client socket.
                // machineName is the host running the server application.
                using (TcpClient client = new TcpClient(machineName, 8080))
                {
                    if (messsageString != "ping")
                        serverMessage = SendData(client, messsageString);
                    else
                        serverMessage = "Pinged";
                    client.Close();
                }
            }
            catch (Exception e)
            {
                serverMessage = "ERR:Connect- " + e.Message;
            }
            return serverMessage;
        }

        static string SendData(TcpClient client, string messsageString)
        {
            using (
            SslStream sslStream = new SslStream(
                   client.GetStream(),
                   false,
                   new RemoteCertificateValidationCallback(ValidateServerCertificate),
                   null
                   ))
            {
                try
                {
                    sslStream.AuthenticateAsClient(serverName);
                }
                catch (Exception e)
                {
                    client.Close();
                    return "ERR:Authent- " + e.Message;
                }

                byte[] messsage = Encoding.Unicode.GetBytes(messsageString);
                sslStream.Write(messsage);
                sslStream.Flush();
                return ReadMessage(sslStream);
            }
        }

        static string ReadMessage(SslStream sslStream)
        {
            // Read the  message sent by the server.
            // The end of the message is signaled using the
            // "<EOF>" marker.
            byte[] buffer = new byte[2048];
            StringBuilder messageData = new StringBuilder();
            int bytes = -1;
            do
            {
                bytes = sslStream.Read(buffer, 0, buffer.Length);

                // Use Decoder class to convert from bytes to UTF8
                // in case a character spans two buffers.
                Decoder decoder = Encoding.Unicode.GetDecoder();
                char[] chars = new char[decoder.GetCharCount(buffer, 0, bytes)];
                decoder.GetChars(buffer, 0, bytes, chars, 0);
                messageData.Append(chars);
                // Check for EOF.
                if (messageData.ToString().IndexOf("<EOF>") != -1)
                {
                    break;
                }
            } while (bytes != 0);

            return messageData.ToString();
        }
    }
}
