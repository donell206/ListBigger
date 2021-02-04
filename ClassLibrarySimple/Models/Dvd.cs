using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySimple.Models
{
    public class Dvd:Items
    {
        public string Genre { get; set; }

        public Dvd(int itemId, string brand, string name, double price) :base(itemId, brand, name, price)
        {

        }
        public override string ToString()
        {
            return base.ToString() + $"\t{Genre}";
        }
    }
}
