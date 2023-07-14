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
                UserRegistration userRegistration = new UserRegistration();
                Console.WriteLine("\nPlease choose the below option: ");
                Console.WriteLine("\n1.Validate First name");
                Console.WriteLine("2.Validate Last Name");
                Console.WriteLine("3.Validate Email Id:");
                Console.WriteLine("4.Validate Mobile Number");
                Console.WriteLine("5.Validate Password");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter First Name: ");
                        string fName = Console.ReadLine();
                        userRegistration.FirstName(fName);
                        break;
                    case 2:
                        Console.WriteLine("Enter Last Name: ");
                        string lName = Console.ReadLine();
                        userRegistration.LastName(lName);
                        break;
                    case 3:
                        Console.WriteLine("Enter Email id: ");
                        string emailId = Console.ReadLine();
                        userRegistration.ValidateEmail(emailId);
                        break;
                    case 4:
                        Console.WriteLine("Enter Phone Number:");
                        string input = Console.ReadLine();
                        userRegistration.PhoneNumber(input);
                        break;
                    case 5:
                        Console.WriteLine("Enter Password: ");
                        string password = Console.ReadLine();   
                        userRegistration.Password(password);
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


