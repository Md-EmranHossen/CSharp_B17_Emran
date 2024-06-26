using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Membership
    {
        public static string Validate(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return "Username must be provided";
            if (string.IsNullOrWhiteSpace(email))
                return "Email must be provided";
            if (string.IsNullOrWhiteSpace(password))
                return "Password must be provided";

            return string.Empty;
        }
    }
}
