using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingRegex
{
    public class UserRegistrationRegex
    {
        public static string VALIDNAMEPATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, VALIDNAMEPATTERN);
        }
        public bool validateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, VALIDNAMEPATTERN);
        }
    }
}