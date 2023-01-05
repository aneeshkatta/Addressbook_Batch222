using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook_Batch222
{
    internal class AdressBookBuilder
    {
        public List<Contact> contacts;
        public AdressBookBuilder()
        {
            this.contacts = new List<Contact>();
        }
        public void AddContact(String first_Name, String last_Name, String present_Address, String city, String state, String zip, String phone_Number, String email_Id)
        {
            bool duplicateCheck = Equals(first_Name);
            if (!duplicateCheck)
            {
                Contact contact = new Contact(first_Name, last_Name, present_Address, city, state, zip, phone_Number, email_Id);
                contacts.Add(contact);
            }
            else
            {
                Console.WriteLine("Cannot add duplicate contacts ");
            }
        }
        public bool Equals(string first_Name)
        {
            if (this.contacts.Any(e => e.first_Name == first_Name))
                return true;
            else
                return false;
        }
        public  void EditContact(string editName)
        {
            foreach (var data in contacts)
            {
                if (data.first_Name == editName)
                {
                    Console.WriteLine("choose the option to change the data \n1)firstName\n2)lastName\n3)Present_Address\n4)City\n5)State\n6)Zip\n7)PhoneNumber\n8)Email_Id");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Please enter the first name : ");
                            string firstName = Convert.ToString(Console.ReadLine());
                            data.first_Name = firstName;
                            break;
                        case 2:
                            Console.WriteLine("Please enter the last name : ");
                            string lastName = Convert.ToString(Console.ReadLine());
                            data.last_Name = lastName;
                            break;
                        case 3:
                            Console.WriteLine("Please enter the Address : ");
                            string address = Convert.ToString(Console.ReadLine());
                            data.present_Address = address;
                            break;
                        case 4:
                            Console.WriteLine("Please enter the city : ");
                            string City = Convert.ToString(Console.ReadLine());
                            data.city = City;
                            break;
                        case 5:
                            Console.WriteLine("Please enter the city : ");
                            string State = Convert.ToString(Console.ReadLine());
                            data.state = State;
                            break;
                        case 6:
                            Console.WriteLine("Please enter the zip Code : ");
                            string ZipCode = Convert.ToString(Console.ReadLine());
                            data.zip = ZipCode;
                            break;
                        case 7:
                            Console.WriteLine("Please enter the Phone Number : ");
                            string PhoneNumber = Convert.ToString(Console.ReadLine());
                            data.phone_Number = PhoneNumber;
                            break;
                        case 8:
                            Console.WriteLine("Please enter the email : ");
                            string Email = Convert.ToString(Console.ReadLine());
                            data.email_Id = Email;
                            break;
                        default:
                            Console.WriteLine("please choose from above options :");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Contact not found{0}", editName);
                }
            }
        }
        public void DeleteContact(string first_Name)
        {
            int flag = 1;
            foreach (Contact contact in contacts)
            {
                if (first_Name.Equals(contact.first_Name))
                {
                    flag = 0;
                    contacts.Remove(contact);
                    Console.WriteLine("Contact Sucessfully deleted");
                    break;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Contact not found");
            }
        }
        public void DisplayContact()
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine("\nFirst name = " + contact.first_Name);
                Console.WriteLine("Last name = " + contact.last_Name);
                Console.WriteLine("present_Address = " + contact.present_Address);
                Console.WriteLine("city = " + contact.city);
                Console.WriteLine("state = " + contact.state);
                Console.WriteLine("zip = " + contact.zip);
                Console.WriteLine("phone_Number = " + contact.phone_Number);
                Console.WriteLine("email_Id = " + contact.email_Id);
            }
        }

    }
}







