using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook_Batch222
{
    internal class Address
    {
        List<Contact> contacts = new List<Contact>();
        Contact contact;
        Dictionary<string, List<Contact>> system = new Dictionary<string, List<Contact>>();
        public void Entry()
        {
            contact = new Contact();
            bool status = true;
            while (status)
            {
                Console.WriteLine("Enter your first_name");
                contact.first_Name = Console.ReadLine();
                if (contacts.Any(data => (data.first_Name == contact.first_Name)))
                {
                    Console.WriteLine("Contact Name already exists");
                }
                else
                {
                    status = false;
                }
            }
            Console.WriteLine("Enter your last_name");
            contact.last_Name = Console.ReadLine();
            Console.WriteLine("Enter your Present_address");
            contact.present_Address = Console.ReadLine();
            Console.WriteLine("Enter your City");
            contact.city = Console.ReadLine();
            Console.WriteLine("Enter your State");
            contact.state = Console.ReadLine();
            Console.WriteLine("Enter your ZipCode");
            contact.zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone_Number");
            contact.phone_Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Email_Id");
            contact.email_Id = Console.ReadLine();
            contacts.Add(contact);
        }
        public void Display()
        {
            foreach (var keyValuePair in system.Keys)
            {
                Console.WriteLine(keyValuePair);
                foreach (Contact data in system[keyValuePair])
                {
                    Console.WriteLine(data.first_Name);
                    Console.WriteLine(data.last_Name);
                    Console.WriteLine(data.present_Address);
                    Console.WriteLine(data.city);
                    Console.WriteLine(data.state);
                    Console.WriteLine(data.zip);
                    Console.WriteLine(data.phone_Number);
                    Console.WriteLine(data.email_Id);

                }
            }
        }
        public void AddMultipleContact()
        {
            Console.WriteLine("Enter Number of Contacts to be Added:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book Name:");
            string bookname = Console.ReadLine();
            while (input > 0)
            {
                Entry();
                input--;
            }
            system.Add(bookname, contacts);
        }

    }
}







