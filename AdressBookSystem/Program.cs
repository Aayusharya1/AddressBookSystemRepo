﻿using System;
using System.Collections.Generic;
using System.Text;
namespace AddressBookSystem
{
    class Program
    {

        static void Main(string[] args)
        {

            AddressBookBinder binder = new AddressBookBinder();
            Console.WriteLine("Enter the name of the address book ............");
            int AnotherBook = 1;
            while(AnotherBook==1)
            { 

                string BookName = Console.ReadLine();
                AddressBook book = new AddressBook();
                book.contactBook = binder.AddAddressBook(BookName, book.contactBook);

                Console.WriteLine("Welcome to Address Book Program");
                int flag = 1;

                while (flag == 1)
                {
                    Console.WriteLine("Select the option. \n1. for adding new contact. \n2. To edit existing contact. \n3. Delete Contact. \n4. exit");

                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the person details to be added ...........");
                            Console.WriteLine("First Name");
                            string firstName = Console.ReadLine();
                            Console.WriteLine("Last Name");
                            string lastName = Console.ReadLine();
                            Console.WriteLine("Address");
                            string address = Console.ReadLine();
                            Console.WriteLine("City");
                            string city = Console.ReadLine();
                            Console.WriteLine("State");
                            string state = Console.ReadLine();
                            Console.WriteLine("Zip code");
                            string zip = Console.ReadLine();
                            Console.WriteLine("Phone Number");
                            string phoneNumber = Console.ReadLine();
                            Console.WriteLine("Email");
                            string email = Console.ReadLine();
                            if (book.AddContact(firstName, lastName, address, city, state, zip, phoneNumber, email))
                            {
                                Console.WriteLine("Contact added successfully");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Contact already exists");
                                break;
                            }
                        case 2:
                            Console.WriteLine("Enter the first name of the contact to be edited ");
                            string name = Console.ReadLine();
                            Contact c = book.FindContact(name);
                            if (c == null)
                            {
                                Console.WriteLine("Address for {0} couldn't be found.", name);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("New Last Name");
                                c.lastName = Console.ReadLine();
                                Console.WriteLine("New Address");
                                c.address = Console.ReadLine();
                                Console.WriteLine("New City");
                                c.city = Console.ReadLine();
                                Console.WriteLine("New State");
                                c.state = Console.ReadLine();
                                Console.WriteLine("New Zip code");
                                c.zip = Console.ReadLine();
                                Console.WriteLine("New Phone Number");
                                c.phoneNumber = Console.ReadLine();
                                Console.WriteLine("New Email");
                                c.email = Console.ReadLine();
                                Console.WriteLine("Details updated for " + name);
                                break;

                            }

                        case 3:
                            Console.WriteLine("Enter the first name of the contact to be deleted ");
                            string name1 = Console.ReadLine();
                            if (book.RemoveContact(name1))
                            {
                                Console.WriteLine("Contact removed successfully");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Contact not found");
                                break;
                            }

                        case 4:
                            Console.WriteLine("Flag is 1/0?");
                            flag = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                    

                }
                Console.WriteLine("enter 1 to insert another book and 0 otherwise...");
                AnotherBook = Convert.ToInt32(Console.ReadLine());

            }
        
        
        }
    }
}

