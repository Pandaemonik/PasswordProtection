using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordProtection.Externals
{
    static class ServerAction
    {
        public static string GetServerSidePass(string Username, string Password)
        {
            var Returnable = string.Empty;

            //TODO: Serverer Fetch goes here

            return Returnable;
        }

        public static bool IsUsernameInServer(string Username)
        {
            var Returnable = false;

            //TODO: Serverer Fetch goes here

            return Returnable;
        }

        public static bool RegisterNewUser(string Username, string Password)
        {
            var Returnable = false;

            //TODO: Serverer Push goes here

            return Returnable;
        }
    }
}
