using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PasswordProtection.Internals
{
    static class Crypto
    {
        const int _SaltSize = 16, _AES_KeySize = 256, _AES_BlockSize = 128, _HashSize = 34, _HashIter = 5000;

        public static string MakeHash(string password)
        {
            /// <summary>
            /// INPUT: string password - A string containing the password to hashed
            /// OUTPUT: A string made from the array of the (salt + hashed password)
            /// DESCRIPTION: Hashes a password using PBKDF2/Rfc2898DeriveBytes for reliable password hashing
            /// </summary>
            byte[] salt, hash, Returnable;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[_SaltSize]);
            hash = new Rfc2898DeriveBytes(password, salt, _HashIter).GetBytes(_HashSize);

            Array.Copy(salt, 0, Returnable = new byte[_SaltSize + _HashSize], 0, _SaltSize);
            Array.Copy(hash, 0, Returnable, _SaltSize, _HashSize);

            return Convert.ToBase64String(Returnable);
        }

        public static bool CompareHash(string password, string savedPasswordHash)
        {
            /// <summary>
            ///INPUT:    string password - A string containing the password to hashed
            ///          string savedPasswordHash - A string containing the hash Array
            ///OUTPUT: true if the password is a match, false if it isn't
            ///DESCRIPTION: Hashes the input password with the input hash and checks it to the input hash
            /// </summary>
            byte[] salt, passHash, dbHash, HashArray;

            try
            {
                HashArray = Convert.FromBase64String(savedPasswordHash);
                Array.Copy(HashArray, 0, salt = new byte[_SaltSize], 0, _SaltSize);
                Array.Copy(HashArray, _SaltSize, dbHash = new byte[_HashSize], 0, _HashSize);

                passHash = new Rfc2898DeriveBytes(password, salt, _HashIter).GetBytes(_HashSize);
            }
            catch (FormatException)
            {
                throw new UnauthorizedAccessException("Wrong Username/Password");
            }
            for (int i = 0; i < _HashSize; i++)
                if (passHash[i] != dbHash[i])
                    return false;
            return true;
        }

        public static void AES_Encrypt(Credentials credentials, string cryptFile)
        {
            byte[] saltBytes = Convert.FromBase64String(getMacAdress());
            RijndaelManaged AES = new RijndaelManaged();

            AES.KeySize = _AES_KeySize;
            AES.BlockSize = _AES_BlockSize;

            var key = new Rfc2898DeriveBytes(credentials.password, saltBytes, _HashIter);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.ISO10126;

            AES.Mode = CipherMode.CBC;

            using (CryptoStream cs = new CryptoStream(new FileStream(cryptFile, FileMode.Create),
                  AES.CreateEncryptor(),
                 CryptoStreamMode.Write))
            {
                credentials.getCredentialsList().ForEach(data =>
                    {
                        byte[] buffer = Encoding.Unicode.GetBytes(data + "\n");

                        cs.Write(buffer, 0, buffer.Length);
                    }
                );
                cs.FlushFinalBlock();
                cs.Close();
            }
        }

        public static Credentials AES_Decrypt(string inputFile, string password)
        {
            byte[] saltBytes = Convert.FromBase64String(getMacAdress());
            List<byte> decryptedByteList = new List<byte>();

            using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Open))
            {
                RijndaelManaged AES = new RijndaelManaged();

                AES.KeySize = _AES_KeySize;
                AES.BlockSize = _AES_BlockSize;

                var key = new Rfc2898DeriveBytes(password, saltBytes, _HashIter);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);
                AES.Padding = PaddingMode.ISO10126;

                AES.Mode = CipherMode.CBC;

                using (CryptoStream cs = new CryptoStream(fsCrypt,
                     AES.CreateDecryptor(),
                     CryptoStreamMode.Read))
                {
                    byte[] buffer = new byte[AES.BlockSize];

                    try
                    {
                        int dataByte;
                        while ((dataByte = cs.ReadByte()) != -1)
                        {
                            decryptedByteList.Add((byte)dataByte);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cs.Close();
                    }
                }
                fsCrypt.Close();
            }

            Credentials Returnable = new Credentials();
            string[] dataList = Encoding.Unicode.GetString(decryptedByteList.ToArray()).Trim().Split('\n');

            foreach (var line in dataList)
            {
                if (line != "" || line != string.Empty)
                    Returnable.Add(new Credential(line.Split(',')));
            }

            return Returnable;
        }

        private static string getMacAdress()
        {
            var macAddr = (
                from nic in NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
                ).FirstOrDefault();

            return macAddr;
        }
    }
}
