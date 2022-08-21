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

        Dictionary<string, List<PersonInformation>> listOfaddressbook = new Dictionary<string, List<PersonInformation>>();
        public void AddContacts(string addressBookName, int numOfContacts)
        {
            listofcontacts.Clear();

            PersonInformation personInformation = new PersonInformation();
            int count = 0;
            while (true)
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
                personInformation.PhoneNumber = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please Enter your Email address ");
                personInformation.Emailaddress = Console.ReadLine();

                listofcontacts.Add(personInformation);
                count++;
                if (count == numOfContacts)
                {
                    listOfaddressbook.Add(addressBookName, listofcontacts);
                    break;
                }

            }


        }

        public void DisplayContacts()
        {
            foreach (PersonInformation data in listofcontacts)
            {
                Console.WriteLine("\nBelow is the details of person in Address Book.");

                Console.WriteLine("\nFirst name : " + data.FirstName + "\nLast name : " + data.LastName + "\nCity : " + data.City + "\nMobile Number : " + data.PhoneNumber + "\nEmail ID : " + data.Emailaddress);
            }

        }
        public void EditContacts()
        {
            Console.WriteLine("To edit the contacts enter First name for verfication");
            string editname = Console.ReadLine();

            foreach (var data in listofcontacts)
            {
                if (data.FirstName == editname)
                {
                    Console.WriteLine("To edit contacts enter\n1.FirstName \n2.LastName \n3.Address \n4 City \n5.phoneNumber \n6.EmailAddress");

                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            string firstname = Console.ReadLine();
                            data.FirstName = firstname;
                            break;



                        case 2:
                            string lastName = Console.ReadLine();
                            data.LastName = lastName;
                            break;

                        case 3:
                            string address = Console.ReadLine();
                            data.Address = address;
                            break;

                        case 4:
                            string city = Console.ReadLine();
                            data.City = city;

                            break;

                        case 5:
                            int phonenumber = Convert.ToInt32(Console.ReadLine());
                            data.PhoneNumber = phonenumber;
                            break;

                        case 6:
                            string emailaddress = Console.ReadLine();
                            data.Emailaddress = emailaddress;
                            break;

                        default:
                            Console.WriteLine("Please enter some valid data");
                            break;


                    }


                }
                else
                {
                    Console.WriteLine("enter valid name");

                }
            }
        }
        public void DeletePerson()
        {
            Console.WriteLine("To delete the contact list enter the first name");
            string deletename = Console.ReadLine();

            for (int i = 0; i < listofcontacts.Count; i++)
            {
                PersonInformation data = listofcontacts[i];
                if (data.FirstName == deletename)
                {
                    listofcontacts.Remove(data);
                    Console.WriteLine("You have sucessfully deleted {0}'s contact.\n", deletename);
                }
                else
                {
                    Console.WriteLine("Please enter the valid name which is present inside of the address book.\n");
                }
            }

        }

    }

}