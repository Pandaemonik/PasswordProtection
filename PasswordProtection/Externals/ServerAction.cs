using System;
using System.Collections;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Threading;

namespace PasswordProtection.Externals
{
    static class ServerAction
    {
        const string serverName = "localhost";
        const int serverPort = 8080;

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

            //TODO: Serverer Fetch goes here

            return Returnable;
        }

        public static bool IsUsernameInServer(string Username)
        {
            var Returnable = false;
            Thread.Sleep(1000);
            //TODO: Serverer Fetch goes here

            return Returnable;
        }

        public static bool RegisterNewUser(string Username, string Password)
        {
            var Returnable = false;

            //TODO: Serverer Push goes here

            return Returnable;
        }

        public static void SendPasswordRequest(string Email)
        {
            //TODO: Serverer Push goes here
        }

        public static void ChangePassword(string Email, string PasswordOld, string PasswordNew)
        {
            //TODO: Serverer Push goes here
        }

        public static string RunClient(string machineName, string serverName,string messsageString)
        {
            // Create a TCP/IP client socket.
            // machineName is the host running the server application.
            TcpClient client = new TcpClient(machineName, 8080);

            SslStream sslStream = new SslStream(
                client.GetStream(),
                false,
                new RemoteCertificateValidationCallback(ValidateServerCertificate),
                null
                );

            try
            {
                sslStream.AuthenticateAsClient(serverName);
            }
            catch (AuthenticationException e)
            {
                Console.WriteLine("Authentication failed - closing the connection.");
                client.Close();
                return string.Empty;
            }

            byte[] messsage = Encoding.Unicode.GetBytes(messsageString);
            sslStream.Write(messsage);
            sslStream.Flush();
            string serverMessage = ReadMessage(sslStream);
            client.Close();

            return serverMessage;
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
                Decoder decoder = Encoding.UTF8.GetDecoder();
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
