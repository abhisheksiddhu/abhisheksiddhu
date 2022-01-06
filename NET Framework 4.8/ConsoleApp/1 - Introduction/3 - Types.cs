using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._1___Introduction
{
    public class Types
    {
        public static void Run()
        {
            int a = -1234567890;
            uint b = 4234567890;
            long c = -8234567890123456789;
            ulong d = 18345678901234567890;
            decimal e = 1234567890123456789012345678.123456789M;
            float f = 123456789012345678901234567890123456789.123456789F;
            double g = 123456789012345678901234567890123456789012345678901234567890.123456789;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);


            char h = 'a';
            string i = "abh";
            Console.WriteLine(h);
            Console.WriteLine(i);

            bool j = true;
            Console.WriteLine(j);

            int[] k = { 1, 2, 3 };
            k[0] = 2;
            Console.WriteLine(k[0]);
            Console.WriteLine(k[1]);
            Console.WriteLine(k[2]);

            k[0] = 52;
            Console.WriteLine(k[0]);

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.Ticks);
        }
    }
}
