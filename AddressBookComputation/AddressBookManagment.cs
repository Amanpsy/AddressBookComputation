using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookComputation
{
    public class AddressBookManagment
    {
        List<PersonInformation> listofcontacts = new List<PersonInformation>();

        public  List<PersonInformation> Addcontacts(int numOfcontacts)
        {

            PersonInformation personInformation = new PersonInformation();

            for (int i = 0; i < numOfcontacts; i++)
            {
                Console.WriteLine(" Please Enter your first name");
                personInformation.FirstName = Console.ReadLine();
                Console.WriteLine("Please Enter your last name ");
                personInformation.LastName = Console.ReadLine();
                Console.WriteLine("Please Enter your address");
                personInformation.Address = Console.ReadLine();
                Console.WriteLine("Please Enter your City ");
                personInformation.City = Console.ReadLine();
                Console.WriteLine("Please Enter your phone number ");
                personInformation.PhoneNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter your Email address ");
                personInformation.Emailaddress = Console.ReadLine();

                listofcontacts.Add(personInformation);




            }
            return listofcontacts;
        }

    }

}