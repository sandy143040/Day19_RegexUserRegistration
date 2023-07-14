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
        public void FirstName(string fName)
        {
            string firstName = "^[A-Z]{1}[a-z]{3,}?$";
            if (Regex.IsMatch(fName, firstName))
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invallid First Name");
            }
        }
        public void LastName(string lName)
        {
            string lastName = "^[A-Z]{1}[a-z]{3,}?$";
            if (Regex.IsMatch(lName, lastName))
            {
                Console.WriteLine("Valid Last Name");
            }
            else
            {
                Console.WriteLine("Invalid Last Name");
            }
        }
        public void ValidateEmail(string emailId)
        {
            string email = "^[A-Za-z0-9]+@[a-z]+[.][a-z]?";
            if (Regex.IsMatch(emailId, email))
            {
                Console.WriteLine("Email is Vaild");
            }
            else
            {
                Console.WriteLine("Email is Invalid");
            }
        }
    }
}
