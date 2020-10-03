using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        public static List<Contact> contactBook;
        public AddressBook()
        {
            contactBook = new List<Contact>();
        }

        public Contact FindContact(string fname)
        {
            Contact contact = contactBook.Find((x) => x.firstName == fname);
            return contact;
        }

        public bool AddContact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            Contact result = FindContact(firstName);
            if (result == null)
            {
                contactBook.Add(contact);
                return true;
            }
            else
                return false;
        }

        public bool RemoveContact(string name)
        {
            Contact c = FindContact(name);
            if (c != null)
            {
                contactBook.Remove(c);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
