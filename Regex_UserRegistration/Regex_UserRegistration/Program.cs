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
            while (true)
            {
                Console.WriteLine("\nPlease choose the below option: ");
                Console.WriteLine("\n1.Validate First name");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UserRegistration userRegistration = new UserRegistration();
                        Console.WriteLine("Enter First Name");
                        string fName = Console.ReadLine();
                        userRegistration.FirstName(fName);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}


