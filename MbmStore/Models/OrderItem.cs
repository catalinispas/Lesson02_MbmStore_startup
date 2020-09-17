using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
   public class OrderItem
    {
        // Fields

        // Properties

        public int OrderItemId { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice
        {
            get
            {
                totalPrice = Product.Price * Quantity;

                return totalPrice;
            }
        }

        // Constructors

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
