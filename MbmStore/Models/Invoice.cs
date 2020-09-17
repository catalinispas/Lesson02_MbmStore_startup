using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Invoice
    {
        // Fields
       
        private decimal totalPrice;

        // Properties

        public int InvoiceId { get; set; }

        public decimal TotalPrice
        {
            get
            {
                foreach (OrderItem item in OrderItems)
                {
                    totalPrice += item.Product.Price * item.Quantity;
                }

                return totalPrice;
            }
        }

        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        // Constructors

        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            InvoiceId = invoiceId;
            OrderDate = orderDate;
            Customer = customer;
        }

        public void AddOrderItem(Product product, int quantity)
        {
            OrderItems.Add(new OrderItem(product, quantity));
        }
    }
}
