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
        //Default Constructor
        public Person()
        {

        }
        //Parameterized Constructor
        public Person(string FirstName, string LastName, string PhoneNumber, string Address, string City, string State, string EmailID)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.EmailID = EmailID;
        }

        //Create method to take user inputs
        public static void AddPerson(int num)
        {
            for (int i = 0; i < num; i++)
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
            }
            Console.WriteLine("...............................................");
        }
        //Create method to display persons details
        
        public static void PrintPerson()
        { 
            foreach (Person person in data)
            {
                Console.WriteLine("Address book of Person");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("First Name: " + person.FirstName);
                Console.WriteLine("Last Name: " + person.LastName);
                Console.WriteLine("Phone Number: " + person.PhoneNumber);
                Console.WriteLine("Address: " + person.Address);
                Console.WriteLine("City: " + person.City);
                Console.WriteLine("State: " + person.State);
                Console.WriteLine("EmailId: " + person.EmailID);
                Console.WriteLine("...............................................");
            }
        }
        //Create method to edit persons details
        public void editContact(string name)
        {
            bool input = false;
            Console.WriteLine("Enter:\n1:Edit first name\n2:Edit last name \n3:Edit Phone Number\n4:Edit Address\n5:Edit City\n6:Edit State\n7:Edit EmailID");
            int option = Convert.ToInt32(Console.ReadLine());
            foreach (Person person in data)
            {
                if (person.FirstName == name) 
                {
                    input = true;
                    switch (option)
                    {
                        case 1:
                            Console.Write("Enter new first name :");
                            string newFirstName = Convert.ToString(Console.ReadLine());
                            person.FirstName = newFirstName;
                            break;
                        case 2:
                            Console.Write("Enter new last name :");
                            string newLastName = Convert.ToString(Console.ReadLine());
                            person.LastName = newLastName;
                            break;
                        case 3:
                            Console.Write("Enter new PhoneNumber :");
                            string newPhoneNumber = Convert.ToString(Console.ReadLine());
                            person.PhoneNumber = newPhoneNumber;
                            break;
                        case 4:
                            Console.Write("Enter new Address :");
                            string newAddress = Convert.ToString(Console.ReadLine());
                            person.Address = newAddress;
                            break;
                        case 5:
                            Console.Write("Enter new City :");
                            string newCity = Convert.ToString(Console.ReadLine());
                            person.City = newCity;
                            break;
                        case 6:
                            Console.Write("Enter new State :");
                            string newState = Convert.ToString(Console.ReadLine());
                            person.State = newState;
                            break;
                        case 7:
                            Console.Write("Enter new EmailID :");
                            string newEmailID = Convert.ToString(Console.ReadLine());
                            person.EmailID = newEmailID;
                            break;
                        default:
                            Console.WriteLine("Please Enter valid Option");
                            break;
                    }

                }
            }
            if (input == false)
                Console.WriteLine("First name not found");
            Person.PrintPerson();
        }
        //Create method to delete contact
        public void removeContact(string name)      
        {
            bool flag = false;
            foreach (Person person1 in data)
            {
                if (person1.FirstName == name)
                {
                    flag = true;
                    data.Remove(person1);
                    Console.WriteLine("The contact is successfully removed");
                    break;
                }
            }
            if (flag == false)
                Console.WriteLine("The contact is not found");
        }
    }
}
