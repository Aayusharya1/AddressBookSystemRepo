using System;

namespace AddressBookSystem
{
    class Program
    {
        AddressBook book;
        public Program()
        {
            book = new AddressBook();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Welcome to Address Book Program");
            bool flag = true;

            while (flag == true)
            {
                Console.WriteLine("Select the option. \n1. for adding new contact. \n2. To edit existing contact. \n3. Exit.");

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
                        if (p.book.AddContact(firstName, lastName, address, city, state, zip, phoneNumber, email))
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
                        Contact c = p.book.FindContact(name);
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
                        flag = false;
                        break;
                }
            }
        }
    }
}

