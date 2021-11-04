using System;

namespace AddressBookDay9
{
    class Program
    {

        static void Main(string[] args)
        {
            //uc1 adding contact details in addressbook
            Addressbook addressBook = new Addressbook();
            Console.WriteLine("enter first name:");
            string firstname = Console.ReadLine();
            Console.WriteLine("enter last name:");
            string lastname = Console.ReadLine();
            Console.WriteLine("enter address:");
            string address = Console.ReadLine();
            Console.WriteLine("enter cityname:");
            string city = Console.ReadLine();
            Console.WriteLine("enter state name:");
            string state = Console.ReadLine();
            Console.WriteLine("enter phone number");
            int phonenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter zip number:");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter mail id");
            string email = Console.ReadLine();

            addressBook.AddEntry(firstname, lastname, address, city, state, phonenumber, zip, email);

            //add person data in multipull addressbook
            Addressbook addressBook1 = new Addressbook();
            Console.WriteLine("enter first name:");
            string firstname1 = Console.ReadLine();
            Console.WriteLine("enter last name:");
            string lastname1 = Console.ReadLine();
            Console.WriteLine("enter address:");
            string address1 = Console.ReadLine();
            Console.WriteLine("enter cityname:");
            string city1 = Console.ReadLine();
            Console.WriteLine("enter state name:");
            string state1 = Console.ReadLine();
            Console.WriteLine("enter phone number");
            int phonenumber1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter zip number:");
            int zip1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter mail id");
            string email1 = Console.ReadLine();

            Console.WriteLine("refctor multiple addressbook1 :" + addressBook1);
            addressBook1.AddEntry(firstname1, lastname1, address1, city1, state1, phonenumber1, zip1, email1);


          // addressBook.updatecontact(firstname);

            //addressBook.ViewContactsList();
           




        }
    }
}

