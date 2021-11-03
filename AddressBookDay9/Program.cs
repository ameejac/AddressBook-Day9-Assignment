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


<<<<<<< HEAD
           // addressBook.updatecontact(firstname);


            addressBook.RemoveEntry(firstname);
=======
           addressBook.updatecontact(firstname);


>>>>>>> uc3-update-contacts-addressbook



        }
    }
}
