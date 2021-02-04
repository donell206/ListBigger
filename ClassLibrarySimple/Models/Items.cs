using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySimple.Models
{
    public class Items:IComparable<Items>
    {
        public int ItemID { get; set; }
        public string  Brand { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


        public Items(int itemId, string brand, string name, double price)
        {
            ItemID = itemId;
            Brand = brand;
            Name = name;
            Price = price;
        }
        public int CompareTo(Items other)
        {
            return Brand.CompareTo(other.Brand);
        }

        public  string GetItemCode()
        {
            return (Brand.PadRight(3).Substring(0,3).ToUpper() + Name.PadRight(3).Substring(0,3).ToUpper());
        }

        public override string ToString()
        {
            return $"{ItemID} Brand: {Brand.PadRight(20)} Name: {Name.PadRight(20)} Price: {Price.ToString("N2").PadRight(10)} Code: {GetItemCode().PadRight(15)}";
        }

       
    }
}
