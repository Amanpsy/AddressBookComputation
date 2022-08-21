
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
                Console.WriteLine("Please choose number as shown below\n1:Add Contacts \n2Display contacts \n3Edit contacts");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressbookmanagment.Addcontacts();


                        break;

                    case 2:
                        addressbookmanagment.DisplayContacts();
                        break;

                    case 3:
                        addressbookmanagment.EditContacts();
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("enter valid value");
                        break;

                }

            }
            while (option != 4);
                Console.ReadLine();

        }

    }
}