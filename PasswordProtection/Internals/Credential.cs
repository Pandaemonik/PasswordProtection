using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordProtection.Internals
{
    public class Credential
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Link { get; set; }
        public string DisplayName { get; set; }

        public string[] toArray()
        {
            return new string[] { DisplayName, Link, Password, Username };
        }

        public static bool IsPasswordVaild(string Email, string Password)
        {
            if (Email == Password || IsPasswordVaild(Password))
                return false;
            return true;
        }

        public static bool IsPasswordVaild(string Password)
        {
            if (Password.Length < 12)
                return false;
            return true;
        }

        public static bool IsEmailValid(string Email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(Email);
                return addr.Address == Email;
            }
            catch
            {
                return false;
            }
        }
    }
}
