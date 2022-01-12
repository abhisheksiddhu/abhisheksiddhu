using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._1___Introduction
{
    internal class Loops
    {
        public static void Run()
        {
            //ForLoop();
            //WhileLoop();
            ForEachLoop();
        }

        public static void ForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void WhileLoop()
        {
            int i = 0;
            for (; i < 10;)
            {
                Console.WriteLine(i);
                i++;
            }

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }

            int k = 10;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < 10);
        }

        public static void ForEachLoop()
        {
            int[] a = { 54, 55, 85, 94, 946, 781, 753, 759 };
            for(int i = 0;i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            foreach(int val in a)
            {
                Console.WriteLine(val);
            }
        }
    }
}
