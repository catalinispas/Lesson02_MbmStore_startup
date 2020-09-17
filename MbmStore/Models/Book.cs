using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Book : Product
    {
        // Fields

        // Properties

        public string Author { get; set; }

        public string Publisher { get; set; }

        public short Published { get; set; }

        public string ISBN { get; set; }

        // Constructors

        public Book(string author, string title, decimal price, short published) : base( title, price)
        {
            Author = author;
            Published = published;
        }
    }
}
