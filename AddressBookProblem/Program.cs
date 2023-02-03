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
            //UC1-Create Contact
            Person.AddPerson();
            Person.PrintPerson();
            Console.ReadLine();
        }
    }
}
