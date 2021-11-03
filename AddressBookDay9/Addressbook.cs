using System;

namespace AddressBookDay9
{
    class Addressbook
    {
        public readonly Contact[] contacts;
        public Addressbook()
        {
            contacts = new Contact[7];
        }
        //uc4 add contacts in addressbook
        public bool AddEntry(string firstname, string lastname, string address, string city, string state, int phonenum, int zip, String email)
        {
            Console.WriteLine("ContainsEntry:" + ContainsEntry(firstname));
            if (!ContainsEntry(firstname))
            {
                Contact addcontact = new Contact(firstname, lastname, address, city, state, phonenum, zip, email);
                Console.WriteLine("if issssssssssss");
                contacts[0] = addcontact;
                Console.WriteLine("firstNAme" + contacts[0].Firstname);

            }
            else
            {
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


<<<<<<< HEAD
        //uc4 remove contacts in addressbook

        public void RemoveEntry(string name)
        {
            Console.WriteLine("would you like to remove the cotact data in addressbook .type y or no:");
            string removeData = Console.ReadLine().ToLower();


            if (removeData == "y")
            {
                Console.WriteLine("please enter the remove contact data");
                string removeContact = Console.ReadLine();

                var index = GetEntryIndex(name);
                if (index != -1)
                {
                    contacts[index] = null;
                    Console.WriteLine("{0} removed from contacts"+name);
                }
            }
            else
            {
                Console.WriteLine("data is not update:");
            }

        }
=======
       
>>>>>>> uc3-update-contacts-addressbook



    }
}
