using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordProtection.Internals
{
    class Credentials
    {
        public string email { get; set; }
        private string password { get; set; }
        private List<Credential> _credentialsList;


    }
}