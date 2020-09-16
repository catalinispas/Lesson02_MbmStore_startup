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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public List<string> PhoneNumbers { get; set; } = new List<string>();
        public int Age { get; set; }

        public DateTime BirthDate
        {
            set
            {
                if (Age<0 || Age>=120)
                {
                    throw new Exception("Age not accepted");
                }
                else
                {
                    birthDate = value;
                }
            }
            get { return birthDate; }
        }


        // Constructors
        public Customer(string firstName, string lastName, string address, string zip, string city, string phone, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Zip = zip;
            City = city;
            PhoneNumbers.Add(phone);

            DateTime now = DateTime.Now;
            int age;
            age = now.Year - birthDate.Year;

            // calculate to see if the customer hasn’t had her birthday yet
            // subtract one year if that is so
            if (now.Month < birthDate.Month ||
             (now.Month == birthDate.Month && now.Day < birthDate.Day))
            {
                age--;
            }
            
            Age = age;
            
            BirthDate = birthDate;

        }

        public void AddPhone(string phone)
        {
           this.PhoneNumbers.Add(phone);
        }







    }

}

