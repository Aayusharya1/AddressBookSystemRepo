using System;
using System.Collections.Generic;
using System.Text;


namespace AddressBookSystem
{
    class Contact
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public int phoneNumber { get; set; }
        public string email { get; set; }
        public Contact(string firstName, string lastName, string address, string city, string state, int zip, int phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
    }
}