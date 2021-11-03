using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookDay9
{
    class Addressbook
    {
        public readonly Contact[] contacts;
        public Addressbook()
        {
            contacts = new Contact[7];
        }
        //uc2 add contacts in addressbook
        public bool AddEntry(string firstname, string lastname, string address, string city, string state, int phonenum, int zip, String email)
        {
            Console.WriteLine("ContainsEntry:" + ContainsEntry(firstname));
            if (!ContainsEntry(firstname))
            {
                Contact addcontact = new Contact(firstname, lastname, address, city, state, phonenum, zip, email);
                Console.WriteLine("if issssssssssss");
                contacts[0] = addcontact;
                Console.WriteLine("firstNAme"+contacts[0].Firstname);

            }
            else {
                Console.WriteLine($"({firstname}) already exists in Address Book!");

            }
            return false;
        }
        private bool ContainsEntry(string firstname)
        {
            return GetEntryIndex(firstname) != -1;
        }
        private int GetEntryIndex(string name)
        {
          for (int i = 0; i < contacts.Length; i++)
            {

                if (contacts[i] != null && contacts[i].Firstname == name)
                {
                    return i;
                }
            }
            return -1;
        }
       



    }
}
