using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MbmStore.Infrastructure;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        // fields

        // properties
        public string Director
        { get; set; }

        public short Released
        {
            get; set;
        }

        public string ImageUrl { get; set; }

        // constructors
        public Movie(int productId, string title, decimal price, string imageUrl) : base(title, price)
        {
            ProductId = productId;
            Title = title;
            Price = price;
            ImageUrl = imageUrl;
        }
    }
}