using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Customer
    {  
        // Fields

        private DateTime birthDate;
       
        // Properties

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public List<string> PhoneNumbers { get; } = new List<string>();
        public DateTime BirthDate
        {
            set
            {
                // Validating that the customer is not too young or too old

                if (value > DateTime.Today.AddYears(-2))
                {
                    throw new Exception("There seems to be a lad too young to be here.");
                }
                if (value < DateTime.Today.AddYears(-120))
                {
                    throw new Exception("There seems to be a lad too dead to be here.");
                }
                else
                {
                    birthDate = value;
                }
            }
            get 
            { 
                return birthDate; 
            }
        }
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age;

                age = now.Year - birthDate.Year;

                // Verifying if customer's Birthday passed

                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    age--;
                }

                return age;
            }
        }
        public List<Invoice> Invoices { get; set; }

        // Constructors

        public Customer(int customerId, string firstname, string lastname, string address, string zip, string city)
        {
            CustomerId = customerId;
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            Zip = zip;
            City = city;
        }

        public void AddPhoneNumber(string phone)
        {
            PhoneNumbers.Add(phone);
        }

        public void AddInvoice(Invoice invoice)
        {
            Invoices.Add(invoice);
        }
    }

}

