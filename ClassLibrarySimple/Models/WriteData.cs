using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySimple.Models
{
    public class WriteData
    {
        public static void WriteListToFile<T>(List<T> list, string path)
        {
            using (var fs = new FileStream(path, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    list.ForEach(x => sw.WriteLine(x));
                }
            }
        }
    }
}
