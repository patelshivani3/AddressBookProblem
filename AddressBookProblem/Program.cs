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
          
            Console.WriteLine("\n1.Create Contact\n2.Add New Contact\n3.Edit Contact\n4.Remove Contact");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
               
                case 1: //UC1 - Create Contact
                    Console.WriteLine("Enter the number of contact you want :");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Person.AddPerson(num);
                    Person.PrintPerson();
                    break;

                case 2://UC2 - Add New Contact
                    Console.WriteLine("Enter the number of contact you want :");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Person.AddPerson(num1);
                    Person.PrintPerson();
                    break;

                case 3://UC3- Edit Contact
                    Console.Write("Enter the Number of Contact You Want :");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Person addPerson = new Person();
                    Person.AddPerson(num2);
                    Person.PrintPerson();
                    Console.Write("Enter the first name to edit contact :");
                    string name = Convert.ToString(Console.ReadLine());
                    addPerson.editContact(name);
                    break;

                case 4://UC4 - Remove Contact
                    Console.Write("Enter the Number of Contact You Want :");
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    Person removePerson = new Person();
                    Person.AddPerson(num3);
                    Person.PrintPerson();
                    Console.Write("Enter the first name to edit contact :");
                    string name1 = Convert.ToString(Console.ReadLine());
                    removePerson.removeContact(name1);
                    break;

                default:
                    Console.WriteLine("\nChoose from given option only!\n");
                    break;
            }
            Console.ReadLine();
        }
    }
}
