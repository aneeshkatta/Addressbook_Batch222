using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook_Batch222
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address  Book System!");
            Dictionary<string, AdressBookBuilder> adressBookDictionary = new Dictionary<string, AdressBookBuilder>();
            while (true)
            {
                try
                {
                    Console.WriteLine("How many adress book you want = ");
                    int numOfAdressBook = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= numOfAdressBook; i++)
                    {
                        Console.WriteLine("Enter the name of adress book = " + i + "=");
                        String adressBookName = Console.ReadLine();
                        AdressBookBuilder adressBookBuilder = new AdressBookBuilder();
                        adressBookDictionary.Add(adressBookName, adressBookBuilder);
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter integer only");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("You have created following adress book");
                    foreach (string k in adressBookDictionary.Keys)
                    {
                        Console.WriteLine(k);
                    }
                    Console.WriteLine("\n 1 for Add Contact \n 2 for Edit Existing Contact \n 3 for delete the person,\n 4 for display,\n  5.Search a Person by City or state \n 6 for exit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the Adress book name where you want to add contact");
                            string addContactInAdressBook = Console.ReadLine();
                            if (adressBookDictionary.ContainsKey(addContactInAdressBook))
                            {
                                Console.WriteLine("Enter how many contact you want to add");
                                int numOfContact = Convert.ToInt32(Console.ReadLine());
                                for (int i = 1; i <= numOfContact; i++)
                                {
                                    takeInputAndAddToContact(adressBookDictionary[addContactInAdressBook]);
                                }
                                adressBookDictionary[addContactInAdressBook].DisplayContact();
                            }
                            else
                            {
                                Console.WriteLine("No adress book found ", addContactInAdressBook);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Enter the Adress book name where you want to edit contact = ");
                            string editContactInAdressBook = Console.ReadLine();
                            if (adressBookDictionary.ContainsKey(editContactInAdressBook))
                            {
                                Console.WriteLine("Enter first name to edit contact =");
                                String first_NameForEditContact = Console.ReadLine();
                                adressBookDictionary[editContactInAdressBook].EditContact(first_NameForEditContact);
                                adressBookDictionary[editContactInAdressBook].DisplayContact();
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter the Adress book name where you want to delete contact = ");
                            string deleteContactInAdressBook = Console.ReadLine();
                            if (adressBookDictionary.ContainsKey(deleteContactInAdressBook))
                            {
                                Console.WriteLine("Enter first name to delete contact =");
                                String first_NameForDeleteContact = Console.ReadLine();
                                adressBookDictionary[deleteContactInAdressBook].DeleteContact(first_NameForDeleteContact);
                                adressBookDictionary[deleteContactInAdressBook].DisplayContact();
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter the Adress book name to display contact = ");
                            String displayContactInAdressBook = Console.ReadLine();
                            adressBookDictionary[displayContactInAdressBook].DisplayContact();
                            break;
                        case 5:
                            FindPersonbystateorCity(adressBookDictionary);
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Enter The Valid Choise");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("please enter integer options only");
                }
            }
        }
        public static void takeInputAndAddToContact(AdressBookBuilder adressBookBuilder)
        {
            Console.WriteLine("Enter first name = ");
            string first_Name = Console.ReadLine();
            Console.WriteLine("Enter last name = ");
            string last_Name = Console.ReadLine();
            Console.WriteLine("Enter present_Address= ");
            String present_Address = Console.ReadLine();
            Console.WriteLine("Enter city= ");
            String city = Console.ReadLine();
            Console.WriteLine("Enter state= ");
            String state = Console.ReadLine();
            Console.WriteLine("Enter zip= ");
            String zip = Console.ReadLine();
            Console.WriteLine("Enter phone_Number= ");
            String phone_Number = Console.ReadLine();
            Console.WriteLine("Enter email_Id= ");
            String email_Id = Console.ReadLine();
            adressBookBuilder.AddContact(first_Name, last_Name, present_Address, city, state, zip, phone_Number, email_Id);
        }
        public static void FindPersonbystateorCity(Dictionary<string, AdressBookBuilder> builder)
        {
            Console.WriteLine("Enter the city or state where you want to find that person ");
            string searchplace = Console.ReadLine();
            foreach (var element in builder)
            {
                List<string> listOfPersonFoundInPlace = element.Value.FindPerson(searchplace);
                if (listOfPersonFoundInPlace.Count == 0)
                {
                    Console.WriteLine("No person in that city/state of adress book  = " + element.Key);
                }
                else
                {
                    Console.WriteLine("The person in that city/state of adress book = " + element.Key + " = ");
                    foreach (var person in listOfPersonFoundInPlace)
                    {
                        Console.WriteLine(person);
                    }
                }
            }
        }
    }
}





