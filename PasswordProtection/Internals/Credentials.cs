using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PasswordProtection.Internals
{
    public class Credentials
    {
        public string email { get; set; }
        public string password { get; set; }
        private string _secCode;
        private List<Credential> _credentialsList;

        public Credentials()
        {
            //Default constructor used for tests
            email = string.Empty;
            password = string.Empty;
            _credentialsList = new List<Credential>();
        }

        public Credentials(string Email, string Password)
        {
            //Read from save file
            email = Email;
            password = Password;
            _credentialsList = new List<Credential>();
        }

        public Credentials(Credentials credentials)
        {
            //Copy credentials. Leave the _credentialsList unset because safety
            email = credentials.email;
            password = credentials.password;
        }

        public string Encode()
        {
            string Returnable = string.Empty;

            return Returnable;
        }

        public void Add(Credential credential)
        {
            _credentialsList.Add(credential);
        }

        public Credential getCredentialAtIndex(int i)
        {
            return _credentialsList[i];
        }

        public void editCredentialAtIndex(Credential credential, int i)
        {
            _credentialsList[i] = credential;
        }

        public void removeCredentialAtIndex(int i)
        {
            _credentialsList.RemoveAt(i);
        }

        public List<string> getCredentialsList()
        {
            var Returnable = new List<string>();
            _credentialsList.ForEach(c => Returnable.Add(c.ToString()));
            return Returnable;
        }
    }
}