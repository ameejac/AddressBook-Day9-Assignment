using System;

namespace AddressBookDay9
{
    class Addressbook
    {
        public readonly Contact[] contacts;
        public Addressbook()
        {
            contacts = new Contact[2];
        }
        //uc4 add contacts in addressbook
            public bool AddEntry(string firstname, string lastname, string address, string city, string state, int phonenum, int zip, String email)
            {
                Console.WriteLine("ContainsEntry:" + ContainsEntry(firstname));
                if (!ContainsEntry(firstname))
                {
                    Contact addcontact = new Contact(firstname, lastname, address, city, state, phonenum, zip, email);
                    Console.WriteLine("firstname:"+ firstname);
                    contacts[0] = addcontact;
                    Console.WriteLine("firstName" + contacts[0].Firstname);

                }
                else
                {
                    Console.WriteLine($"({firstname}) already exists in Address Book!");

                }
                return false;
            }


        public bool AddMultiplePersondata(string firstname, string lastname, string address, string city, string state, int phonenum, int zip, String email)
        {
            if (!ContainsEntry(firstname))
            {
                Contact AddContact = new Contact(firstname, lastname, address, city, state, phonenum, zip, email);

                for (int i = 0; i < contacts.Length; i++)
                {
                    if (contacts[i] == null)
                    {
                        contacts[i] = AddContact;
                        Console.WriteLine("Address Book updated. {0} has been added!", firstname);
     
                        return true;
                    }
                }
                Console.WriteLine($"Cannot add ({firstname}) to Address Book since it is full!");
                return false;
            }
            else
            {
                Console.WriteLine($"({firstname}) already exists in Address Book!");
               // UpdateContact(name);
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
        public string ViewContactsList()
        {
            string contactList = "";
            Console.WriteLine("contactlist" + contacts.Length);
            foreach (Contact contact in contacts)
            {
                if (contact == null)
                {
                    continue;
                }
                Console.WriteLine("contactlist"+ contact.Firstname);
                contactList += String.Format("Name: {0} -- Address: {1}" + Environment.NewLine, contact.Firstname, contact.State);
           
            
            }
            return (contactList != String.Empty) ? contactList : "Your Address Book is empty.";
        }
    }
}
