using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookComputation
{
    public class PersonInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public string City { get; set; }
        public double PhoneNumber { get; set; }

        public string Emailaddress { get; set; }

        public double _PhoneNumber
        {
            get { return PhoneNumber; }
            set
            {
                if (value < 10)
                {
                    Console.WriteLine("Enter mobile number value should be 10");
                    return;
                }
                else
                {
                    PhoneNumber = value;
                }
                }
            }
        }
      


    }

