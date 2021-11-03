using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookDay9
{
    class Contact
    {
        public string Firstname;
        public string Lastname;
        public string City;
        public string State;
        public int Phonenum;
        public int Zip;
        public string Email;
        public  Contact(string firstname,string lastname,string address,string city,string state,int phonenum,int zip,String email)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Phonenum = phonenum;
            this.State = state;
            this.Zip = zip;
            this.City = city;
            this.Email = email;

        }
    }
}
