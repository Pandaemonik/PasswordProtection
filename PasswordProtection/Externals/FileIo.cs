using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordProtection.Internals;

namespace PasswordProtection.Externals
{
    static class FileIo
    {
        private static string[] _WordList;

        public static void initWordList()
        {
            if (_WordList == null || _WordList.Length == 0)
            {
                var path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "WordList.csv");
                using (var reader = new System.IO.StreamReader(@path))
                {
                    var line = reader.ReadLine();
                    _WordList = line.Split(';');
                }
            }
        }

        public static string generateSuggestion()
        {
            //Generates a string made form 4 random words. The dictonaty used is the "Oxford 3000" list. The number of combinations possible is 4^3262
            var Suggestion = string.Empty;
            if (_WordList == null)
            {
                initWordList();
            }
            do
            {
                Random random = new Random();
                for (int i = 0; i < 4; i++)
                    Suggestion += _WordList[random.Next(0, _WordList.Length - 1)] + " ";
            } while (!Credential.IsPasswordVaild(Suggestion));

            return Suggestion.Trim();
        }

        public static Credentials Import(Credentials credentials, string Path)
        {
            if (File.Exists(Path))
            {
                using (var reader = new StreamReader(Path))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        credentials.Add(new Credential(values));
                    }
                }
            }
            return credentials;
        }

        public static void Export(Credentials credentials)
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(Path.Combine(
                Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),
                "Passwords_-_",
                getFilenameFromEmail(credentials.email),
                ".csv")))
            {
                string csv = string.Empty;
                credentials.getCredentialsList().ForEach(c => sw.WriteLine(c));
            }
        }

        public static string openFile()
        {
            var openFileDialog = new System.Windows.Forms.OpenFileDialog();
            string buffer = string.Empty;

            openFileDialog.InitialDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            openFileDialog.Filter = "CSV files (*.csv)|*csv|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return "NULL";
        }

        public static void saveCredentialToEncryptedFile(Credentials credentials)
        {
            var Filename = getFilenameFromEmail(credentials.email);
            var path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), Filename + ".enc");
            Crypto.AES_Encrypt(credentials, path);
        }

        public static Credentials readCredentialFromEncryptedFile(string Username, string password)
        {
            var Filename = getFilenameFromEmail(Username);
            var path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), Filename + ".enc");

            if (File.Exists(path))
            {
                Credentials Returnable = Crypto.AES_Decrypt(path, password);
                Returnable.email = Username;
                Returnable.password = password;
                return Returnable;
            }
            else
                return new Credentials(Username, password);

        }

        static string getFilenameFromEmail(string username)
        {
            return username.Substring(0, username.LastIndexOf('@')); ;
        }
    }
}