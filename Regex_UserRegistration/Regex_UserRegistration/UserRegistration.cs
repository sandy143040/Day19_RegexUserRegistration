using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_UserRegistration
{
    public class UserRegistration
    {
        public void EmailValidate(string input)
        {
            string email = "^[a-zA-Z0-9/.]+[@][a-z]+[/.][a-z]{2,3}?$";
            if(Regex.IsMatch(input, email))
            {
                Console.WriteLine("Valid Email ID");
            }
            else
            {
                Console.WriteLine("Invalid Email ID");
            }
        }
    }
}
