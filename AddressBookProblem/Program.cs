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
          
            Console.WriteLine("\n1.Create Contact\n2.Add New Contact\n3.Edit Contact\n4.Remove Contact\n5.Multiple Contacts\n6.Multiple Address Book\n7.Check Duplicate Name\n8.Search By city or state\n9.Number of contact having same city");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
               
                case 1: //UC1 - Create Contact
                    Console.WriteLine("Enter the number of contact you want to add:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Person.AddPerson(num);
                    Person.PrintPerson();
                    break;

                case 2://UC2 - Add New Contact
                    Console.WriteLine("Enter the number of contact you want to add:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Person.AddPerson(num1);
                    Person.PrintPerson();
                    break;

                case 3://UC3- Edit Contact
                    Console.Write("Enter the Number of Contact You Want to add:");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Person addPerson = new Person();
                    Person.AddPerson(num2);
                    Person.PrintPerson();
                    Console.Write("Enter the first name to edit contact :");
                    string name = Convert.ToString(Console.ReadLine());
                    addPerson.editContact(name);
                    break;

                case 4://UC4 - Remove Contact
                    Console.Write("Enter the Number of Contact You Want to add :");
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    Person removePerson = new Person();
                    Person.AddPerson(num3);
                    Person.PrintPerson();
                    Console.Write("Enter the first name to edit contact :");
                    string name1 = Convert.ToString(Console.ReadLine());
                    removePerson.removeContact(name1);
                    break;

                case 5://UC5- Add multiple Contacts
                    Console.WriteLine("Enter the number of contact you want to add:");
                    int num4 = Convert.ToInt32(Console.ReadLine());
                    Person.AddPerson(num4);
                    Person.PrintPerson();
                    break;

                case 6://UC6
                    Person.MultipleAddressBook();
                    break;

                case 7://UC7
                    Console.Write("Enter the number of contact you want to add:");
                    int num5 = Convert.ToInt32(Console.ReadLine());
                    Person.AddPerson(num5);
                    Person.PrintPerson();
                    Console.Write("Enter First Name: ");
                    string name2 = Convert.ToString(Console.ReadLine());
                    Person.Duplicate(name2);
                    Person.AddPerson(num5);
                    Person.PrintPerson();
                    break;

                case 8://UC8
                    Console.Write("Enter the number of contact you want to add:");
                    int num6 = Convert.ToInt32(Console.ReadLine());
                    Person.AddPerson(num6);
                   // Person.PrintPerson();
                    Console.Write("Enter The City or state: ");
                    string city = Convert.ToString(Console.ReadLine());
                    Person.SearchCityOrState(num6,city);
                    break;

                case 9://UC9 and UC10
                    Console.Write("Enter the number of contact you want to add:");
                    int num7 = Convert.ToInt32(Console.ReadLine());
                    Person.AddPerson(num7);
                    
                    Console.Write("Enter The City or State: ");
                    string city1 = Convert.ToString(Console.ReadLine());
                    Person.SearchCityOrState(num7,city1);
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
