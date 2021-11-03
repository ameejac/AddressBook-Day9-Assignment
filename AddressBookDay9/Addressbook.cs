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

        //uc3 update contacts in addressbook
        public bool updatecontact(string name)
        {
            Console.WriteLine("would you like to edit the cotact data in addressbook .type y or no:");
            string updatedata = Console.ReadLine().ToLower();
            Console.WriteLine("u can choose to change the  name or address or number ");
                if (updatedata == "y")
                {
                    Console.WriteLine("please enter the updated contact data");
                    string updatecontact = Console.ReadLine();

                    int index = GetEntryIndex(name);
                    Console.WriteLine("index:" + index);
                    contacts[index].Firstname = updatecontact;
                    Console.WriteLine("updatename:" + updatecontact);

                }
                else
                {
                    Console.WriteLine("data is not update:");
                }
            return false;
        }


    



    }
}
