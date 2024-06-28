using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Membership
    {
        private const string userError = "Username must be provided";
        private const string emailError = "Email must be provided";
        private const string passwordError = "Password must be provided";

        public static string Validate(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return userError;
            if (string.IsNullOrWhiteSpace(email))
                return emailError;
            if (string.IsNullOrWhiteSpace(password))
                return passwordError;

            return string.Empty;
        }
    }
}
