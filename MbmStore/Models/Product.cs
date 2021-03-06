﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Product
    {
        // Fields

        // Properties

        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
 

        // Constructors

        public Product() { }

        public Product(string title, decimal price)
        {
            Price = price;
            Title = title;
        }
    }
}
