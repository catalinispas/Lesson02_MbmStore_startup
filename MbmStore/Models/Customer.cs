using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Customer
    {
        // Properties 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public List<string> PhoneNumbers { get; } = new List<string>();
       
        // Constructors
        public Customer(string firstName, string lastName, string address, string zip, string city, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Zip = zip;
            City = city;
            Phone = phone;
        }
    }
}
