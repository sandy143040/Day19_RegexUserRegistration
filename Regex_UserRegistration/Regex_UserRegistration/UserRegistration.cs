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
        public void LastName(string lName)
        {
            string lastName = "^[A-Z]{1}[a-z]{3,}?$";
            if(Regex.IsMatch(lName, lastName))
            {
                Console.WriteLine("Valid Last Name");
            }
            else
            {
                Console.WriteLine("Invalid Last Name");
            }
        }
    }
}
