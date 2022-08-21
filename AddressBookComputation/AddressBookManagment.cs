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

        public void Addcontacts()
        {

            PersonInformation personInformation = new PersonInformation();

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




            }
            
        public void DisplayContacts()
        {
            foreach(var data in listofcontacts)
            {
                Console.WriteLine("\nFirst name is  " + data.FirstName + "\nLast name is   "   + data.LastName + "\nAddress is    "  + data.Address  + "\nCity is   "  + data.City + "\n Phone number is  "   + data.PhoneNumber  +   "\nEmail address is   "   + data.Emailaddress) ;
            }

        }
        public void EditContacts()
        {
            Console.WriteLine("To edit the contacts enter First name for verfication");
            string editname = Console.ReadLine() ;

            foreach (var data in listofcontacts) 
            {
                if(data.FirstName == editname)
                {
                
                    Console.WriteLine("To edit contacts enter\n1.Lastname\n2.City\n3.State\n4.Zip\n5.Mobile Number\n6.Email ID");
                        
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch(option)
                    {
                        case 1: string lastName = Console.ReadLine();
                            data.LastName = lastName;
                            break;

                        case 2:
                            string address = Console.ReadLine();
                            data.Address = address;
                            break;

                        case 3:
                            string city = Console.ReadLine();
                            data.City = city;

                          break;

                        case 4:
                            int phonenumber = Convert.ToInt32(Console.ReadLine());
                            data.PhoneNumber = phonenumber;
                            break;

                        case 5:
                            string emailaddress = Console.ReadLine();
                            data.Emailaddress = emailaddress;
                            break;

                        default:
                            Console.WriteLine("Please enter some valid data");
                            break;


                    }
                
                
                }

            }
        }
        }

    }

