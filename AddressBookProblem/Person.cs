using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string EmailID { get; set; }
        public static List<Person> data = new List<Person>();

        //Create method to take user inputs
        public static void AddPerson()
        {
            Person person = new Person();
            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();
            Console.Write("Enter Address: ");
            person.Address = Console.ReadLine();
            Console.Write("Enter the City: ");
            person.City = Console.ReadLine();
            Console.Write("Enter the state: ");
            person.State = Console.ReadLine();
            Console.Write("Enter the EmailId:");
            person.EmailID = Console.ReadLine();
            data.Add(person);
            Console.WriteLine("...............................................");
        }
        //Create method to display persons details
        
        public static void PrintPerson()
        { 
            foreach (Person person in data)
            {
                Console.WriteLine("\nAddress book of Person");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("First Name: " + person.FirstName);
                Console.WriteLine("Last Name: " + person.LastName);
                Console.WriteLine("Phone Number: " + person.PhoneNumber);
                Console.WriteLine("Address: " + person.Address);
                Console.WriteLine("City: " + person.City);
                Console.WriteLine("State: " + person.State);
                Console.WriteLine("EmailId: " + person.EmailID);
                
            }
        }
    }
}
