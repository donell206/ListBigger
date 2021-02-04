using ClassLibrarySimple.Models;
using ListBigger.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WindowWidth = Console.LargestWindowWidth; 

            Orders order = Factory.CreateOrders();
            order.AddItem(Factory.CreateBook("PDF", "C# step by step", 15.25));
            order.AddItem(Factory.CreateDvd("Series", "Back To the Future", 27.25));
            order.AddItem(Factory.CreateBook("Hard Cover", "ASP.NET", 6.50));
            order.AddItem(Factory.CreateDvd("Movie", "Rush hours", 17.80));


            SaveOrders(order, Directory.GetCurrentDirectory() + @"\Orders.txt");
            order.ShowList();
           
            Console.WriteLine("\nTotale prijs: " + order.TotalPrice().ToString("C2"));
            Console.ReadKey();

        }

        private static void SaveOrders(Orders order, string filename)
        {
            try
            {
                WriteData.WriteListToFile(order.OrdresCollection, filename);
                File.AppendAllText(filename, "Totale prijs: " + order.TotalPrice().ToString("C2"));
            }
            catch (Exception err)
            {
                Console.WriteLine("Er is een fout opgetreden bij het opslaan van de bestelling: " + err.Message);
            }
        }
    }
}
