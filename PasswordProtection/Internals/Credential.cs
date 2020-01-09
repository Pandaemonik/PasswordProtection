namespace PasswordProtection.Internals
{
    public class Credential
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Link { get; set; }
        public string DisplayName { get; set; }

        public Credential(string displayName, string link, string username, string password)
        {
            DisplayName = displayName;
            Link = link;
            Username = username;
            Password = password;
        }

        public Credential(string[] InitList)
        {
            if (InitList.Length < 3)
            {
                DisplayName = InitList[0];
                Link = InitList[1];
            }
            else
            {
                DisplayName = InitList[0];
                Link = InitList[1];
                Username = InitList[2];
                Password = InitList[3];
            }
        }

        public Credential()
        {
            DisplayName = Username = Password = "N/A";
            Link = "https://www.google.com/";
        }

        public string[] ToArray()
        {
            return new string[] { DisplayName, Link, Password, Username };
        }

        public override string  ToString()
        {
            return DisplayName + ',' + Link + ',' + Username + ',' + Password;
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
