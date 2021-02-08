using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySimple.Models
{
    static class Logger
    {
        
        public static void Log (string path, string message)
        {
            using (var fs = new FileStream(path, FileMode.Append))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine(message);
                }
            }
        }
    }
}
