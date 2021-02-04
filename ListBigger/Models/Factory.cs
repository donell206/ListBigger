using ClassLibrarySimple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListBigger.Models
{
    public class Factory
    {
        public static Dvd CreateDvd(string brand, string name,  double prijs)
        {
            return new Dvd(Orders.ItemId, brand, name,  prijs);
        }

        public static Book CreateBook(string brand, string name, double prijs)
        {
            return new Book(Orders.ItemId, brand, name, prijs);
        }

        public static Orders CreateOrders()
        {
            return new Orders();
        }
    }
}
