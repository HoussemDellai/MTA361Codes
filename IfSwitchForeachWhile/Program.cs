using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfSwitchForeachWhile
{
    class Program
    {

        const int x = 0;

        static void Main(string[] args)
        {
            var tab = new int[3]
            {
                3, 2, 5
            };
            var list = new List<int>
            {
                5, 3, 2
            };
            list.Add(5);
            list.Add(3);
            list.Remove(3);

            for (var i = 0; i < list.Count; i++)
            {
                var v = list[i];
                Console.WriteLine(v);
            }

            var d = 5d;

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            //while (true)
            //{

            //}

            //do
            //{

            //} while (true);

            string s = "Mohamed";

            switch (s)
            {
                case "Ahmed":
                    Console.WriteLine("Ahmed");
                    break;
                case "Mohamed":
                    Console.WriteLine("Mohamed");
                    break;
            }

            if (s == "Ahmed")
            {
                Console.WriteLine("Ahmed");
                Console.WriteLine("Mohamed");
            }
            else if (s == "Mohamed")
            {
                Console.WriteLine("Mohamed");
            }
            short b;// int16
            int c;//int32
            long a = 5;// int64
            string str = string.Empty;//""
            String str1 = "";
            float f1 = 5.21f;
            bool b1 = true;
            Boolean b2 = false;
            Console.Read();
        }
    }
}
