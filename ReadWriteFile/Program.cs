using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new StreamWriter(@"D:\data.txt");
            sw.WriteLine("ISET Jendouba :)");

            var sr = new StreamReader(@"D:\data.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
