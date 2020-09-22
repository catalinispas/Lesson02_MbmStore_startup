using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore;
using MbmStore.Models;

namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        // List of products and invoices
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();
        // constructor
        static Repository()
        {
            // Customers

            Customer customer1 = new Customer(1, "Catalin", "Ispas", "Sondervangen 73", "86023", "Viby J");
            Customer customer2 = new Customer(2, "Sebastian", "Bastion", "Sondervangen 68", "86023", "Viby J");

            // create objects

            // Books

            Book myBook = new Book("Georg Martin", "The Making of Sgt.Pepper", 180.00M, 1995);
            Products.Add(myBook);

            Products.Add(new Book("Steve Turner", "Hard Day's Write", 150.00M, 2005));
            Products.Add(myBook);


            // MusicCDs

            /////// cd1

            MusicCD cd1 = new MusicCD("Pink Floyd", "Wish you were here", 250.00M, 1975);
            
            Track cd1tr1 = new Track("Shine On You Crazy Diamond(Parts I–V)", new TimeSpan(0, 0, 0));
            cd1.AddTrack(cd1tr1);

            Track cd1tr2 = new Track("Welcome to the Machine", new TimeSpan(0, 0, 0));
            cd1.AddTrack(cd1tr2);

            Products.Add(cd1);

            /////// cd2

            MusicCD cd2 = new MusicCD("Disturbed", "Ten Thousand Fists", 259.00M, 2005);

            Track cd2tr1 = new Track("Stricken", new TimeSpan(0, 0, 0));
            cd2.AddTrack(cd2tr1);

            Track cd2tr2 = new Track("Just Stop", new TimeSpan(0, 0, 2));
            cd2.AddTrack(cd2tr2);

            Products.Add(cd2);
            

            // Movies
            /////// movie1

            Movie movie1 = new Movie(1, "Jungle Book", 150.00M,"/images/JungleBook.jpg");
            Products.Add(movie1);

            Movie movie2 = new Movie(2, "Forrest Gump", 250.00M, "images/forrest-gump.jpg");
            Products.Add(movie2);

            Movie movie3 = new Movie(3, "Gladiator", 30.00M, "images/gladiator.jpg");
            Products.Add(movie3);

            // Invoices

            Invoice invoice1 = new Invoice(1, new DateTime(2020,10,09), customer1);
            invoice1.AddOrderItem(movie1, 2);
            invoice1.AddOrderItem(cd2, 1);

            Invoice invoice2 = new Invoice(2, new DateTime(2020,09,01), customer2);
            invoice2.AddOrderItem(movie3, 6);
            invoice2.AddOrderItem(myBook, 2);

            Invoices.Add(invoice1);
            Invoices.Add(invoice2);

        }
    }
}
