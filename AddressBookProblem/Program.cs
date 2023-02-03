using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Address Book Program");
          
            Console.WriteLine("\n1.Create Contact\n2.Add New Contact");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
               
                case 1: //UC1 - Create Contact
                    Console.WriteLine("Enter the number of contact you wanted to Make");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Person.AddPerson(num);
                    Person.PrintPerson();
                    break;

                case 2://UC2 - Add New Contact
                    Console.WriteLine("Enter the number of contact you wanted to Make");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Person.AddPerson(num1);
                    Person.PrintPerson();
                    break;

                default:
                    Console.WriteLine("\nChoose from given option only!\n");
                    break;
            }
            Console.ReadLine();
        }
    }
}
