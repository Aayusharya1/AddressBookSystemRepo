using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    public class AddressBook
    {

        public List<Contact> contactBook;
        public AddressBook()
        {
            contactBook = new List<Contact>();
        }

        public Contact FindContact(string fname)
        {
            Contact contact = null;
            foreach (var x in contactBook)
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
        public void AlphabeticallyArrange()
        {
            List<string> alphabeticalList = new List<string>();
            foreach (Contact c in contactBook)
            {
                string sort = c.ToString();
                alphabeticalList.Add(sort);
            }
            alphabeticalList.Sort();
            foreach (string s in alphabeticalList)
            {
                Console.WriteLine(s);
            }
        }

        public void SortByPincode()
        {
            contactBook.Sort(new Comparison<Contact>((x, y) => string.Compare(x.zip, y.zip)));
            foreach (Contact c in contactBook)
            {
                Console.WriteLine(c.firstName + "\t" + c.lastName + "\t" + c.address + "\t" + c.city + "\t" + c.state + "\t" + c.zip + "\t" + c.phoneNumber + "\t" + c.email);
            }
        }
        //Arranging the contacts in the address book according to the city name

        public void SortByCity()
        {
            contactBook.Sort(new Comparison<Contact>((x, y) => string.Compare(x.city, y.city)));
            foreach (Contact c in contactBook)
            {
                Console.WriteLine(c.firstName + "\t" + c.lastName + "\t" + c.address + "\t" + c.city + "\t" + c.state + "\t" + c.zip + "\t" + c.phoneNumber + "\t" + c.email);
            }

        }
        //Arranging the contacts in the address book according to the state name

        public void SortByState()
        {
            contactBook.Sort(new Comparison<Contact>((x, y) => string.Compare(x.state, y.state)));
            foreach (Contact c in contactBook)
            {
                Console.WriteLine(c.firstName + "\t" + c.lastName + "\t" + c.address + "\t" + c.city + "\t" + c.state + "\t" + c.zip + "\t" + c.phoneNumber + "\t" + c.email);
            }

        }
    }
}
