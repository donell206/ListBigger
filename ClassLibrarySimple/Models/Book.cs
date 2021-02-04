using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySimple.Models
{
    public class Book:Items
    {
        public string Pages { get; set; }

        public Book(int itemId, string brand, string name, double price) : base(itemId, brand, name, price)
        {

        }
        public override string ToString()
        {
            return base.ToString() + $"\t{Pages}";
        }
    }
}
