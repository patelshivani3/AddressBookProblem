using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public static Dictionary<string, Person> contactDictionary = new Dictionary<string, Person>();
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
                Console.WriteLine("Address book of " + person.FirstName);
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
        //UC6- create multiple Address book method
        public static void AddPerson1()
        {
            Console.Write("Enter how many contacts you want to add :");
            int num = Convert.ToInt32(Console.ReadLine());
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
        //UC6
        public static void MultipleAddressBook()
        {
            //Create Dictionary
            Dictionary<string, List<Person>> personDict = new Dictionary<string, List<Person>>();      
            int i = 1;
            Console.WriteLine("How many Address Books you want to add :");
            int input = Convert.ToInt32(Console.ReadLine());
            while (i <= input)
            {
                Console.Write("Enter the name for Address Book :");
                string Name = Console.ReadLine();
                AddPerson1();
                personDict.Add(Name, data);
                Console.WriteLine("\n" + Name);
                PrintPerson();
                i++;
            }
        }
        //UC7
        public static void Duplicate(string firstName)
        {
            Person people = data.Find(p => p.FirstName.Equals(firstName));
            if (people != null)
            {
                Console.WriteLine("Contact is already present");
            }
        }

        public static void PrintPerson1(Person contact)
        {
            foreach (Person person in data)
            {
                Console.WriteLine("Address book of " + person.FirstName);
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
        //UC8 and UC10
        public static  void SearchCityOrState(int n,string city)
        {
            bool flag = false;
            int count =0 ;           
            foreach (Person person in data)
            {
                for (int i = 0; i < n; i++)
                {
                    if (person.City == city || person.State == city)
                    {
                        flag = true;
                        Console.WriteLine("The contact is Found");
                        count++;
                        data.Add(person);
                        break;
                    }
                }                              
            }
            Console.WriteLine(count + " Contacts are Present in Address Book");
            if (flag == false)
                Console.WriteLine("The contact is not found");
        }
        

    }
}
