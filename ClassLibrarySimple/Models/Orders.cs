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
            Log(item);
            ItemId++;
        }

        private static void Log(Items item)
        {
            string line = $"on {DateTime.Now} new activity added  Brand: {item.Brand }, Name: {item.Name}, Price: {item.Price}";
            Logger.Log("Logger.txt", line);
        }

        public void ShowList()
        {
            OrdresCollection.ForEach(i => Console.WriteLine(i));

            //foreach (var item in OrdresCollection)
            //{
            //    Console.WriteLine(item);
            //}

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
