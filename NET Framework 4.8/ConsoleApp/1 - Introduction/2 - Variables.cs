using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._1___Introduction
{
    public class Variables
    {
        public static void Run()
        {
            string a = "hello";
            a = "world";
            Console.WriteLine(a);

            string[] b = { "hello", "world" };
            Console.WriteLine(b[0]);
            Console.WriteLine(b[1]);
            b[1] = "universe";
            Console.WriteLine(b[1]);
        }
    }
}
