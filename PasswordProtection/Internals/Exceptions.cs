using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordProtection.Internals
{
    public class UnauthorizedAccessException : Exception
    {
        public UnauthorizedAccessException(string message) : base(message)
        {
        }
    }

    public class DatabaseConnectionFailure : Exception
    {
        public DatabaseConnectionFailure(string message) : base(message)
        {
        }
    }
}

