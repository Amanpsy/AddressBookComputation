
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookComputation
{
    class program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book Program");

            AddressBookManagment addressbookmanagment = new AddressBookManagment();
            int option;
            do
            {
                Console.WriteLine("Please choose number as shown below\n1:Add Contacts \n2:Display contacts \n3:Edit contacts \n4:Delete Contacts");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please enter unique address book name");
                        string addressBookName = Console.ReadLine();
                        Console.WriteLine("Please enter how many contact do you want to add under address book?");
                        int numOfContacts = Convert.ToInt32(Console.ReadLine());
                        addressbookmanagment.AddContacts(addressBookName, numOfContacts);
                        break;

                    case 2:
                        addressbookmanagment.DisplayContacts();
                        break;

                    case 3:
                        addressbookmanagment.EditContacts();
                        break;

                    case 4:
                        addressbookmanagment.DeletePerson();
                        break;

                    default:
                        Console.WriteLine("enter valid value");
                        break;

                }

            }
            while (option != 5);
                Console.ReadLine();

        }


    }
}