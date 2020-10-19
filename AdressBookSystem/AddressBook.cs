using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    public class AddressBook
    {
       
        public HashSet<Contact> contactBook;
        public AddressBook()
        {
            contactBook = new HashSet<Contact>();
        }

        public Contact FindContact(string fname)
        {
            Contact contact = null;
            foreach(var x in contactBook) 
            {
                if (x.firstName == fname) 
                {
                    contact = x;
                    break;
                }

                
            }
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
