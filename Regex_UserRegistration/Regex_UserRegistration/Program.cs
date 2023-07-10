using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Enter Last Name");
            string lName = Console.ReadLine();
            userRegistration.LastName(lName);

            Console.ReadLine();
        }
    }
}


