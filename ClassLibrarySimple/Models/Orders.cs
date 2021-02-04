using ClassLibrarySimple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySimple.Models
{
    public class Orders : ICalculate
    {
        public List<Items> OrdresCollection { get; set; } = new List<Items>();
        public static int ItemId { get; set; } = 1;

        public void AddItem(Items item)
        {
            OrdresCollection.Add(item);
            ItemId++;
        }

        public void ShowByBrand(string brand)
        {
            var results = OrdresCollection.Where(x => x.Brand.ToUpper().Contains(brand.ToUpper())).ToList();
            results.ForEach(x => Console.WriteLine(x));
        }

        public void ShowList()
        {
            OrdresCollection.ForEach(i => Console.WriteLine(i));
        }

        public void SortByBrand()
        {
            OrdresCollection.Sort();
        }

        public double TotalPrice()
        {
            return OrdresCollection.Sum(x => x.Price);
        }
    }
}
