using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Addressbook_Batch222
{
    internal class Addressbook
    {
        internal class Contact
        {
            public string First_Name { get; set; }
            public string Last_Name { get; set; }
            public string Present_Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Email_Id { get; set; }
            public string Phone_Number { get; set; }
            public string Zip { get; set; }
        }
        public static void Main(string[] args)
        {
            List<Contact> Addressbook = new List<Contact>();
            Contact contact = new Contact();
            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("Add a New Contact:");
            Console.WriteLine("Enter your first_name");
            contact.First_Name = Console.ReadLine();
            Console.WriteLine("Enter your last_name");
            contact.Last_Name = Console.ReadLine();
            Console.WriteLine("Enter your Present_address");
            contact.Present_Address = Console.ReadLine();
            Console.WriteLine("Enter your City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter your State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter your Email_Id");
            contact.Email_Id = Console.ReadLine();
            Console.WriteLine("Enter your Phone_Number");
            contact.Phone_Number = Console.ReadLine();
            Console.WriteLine("Enter your ZipCode");
            contact.Zip = Console.ReadLine();
            Addressbook.Add(contact);

            foreach (var data in Addressbook)
            {
                Console.WriteLine("---------Contact Details--------");
                Console.WriteLine("First_Name " + data.First_Name);
                Console.WriteLine("Last_Name " + data.Last_Name);
                Console.WriteLine("Present_Address " + data.Present_Address);
                Console.WriteLine("City " + data.City);
                Console.WriteLine("State " + data.State);
                Console.WriteLine("Email_Id " + data.Email_Id);
                Console.WriteLine("Phone_Number " + data.Phone_Number);
                Console.WriteLine("Zip " + data.Zip);
            }


        }


    }
}

