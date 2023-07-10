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
            if(Regex.IsMatch(fName, firstName))
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invallid First Name");
            }
        }
    }
}
