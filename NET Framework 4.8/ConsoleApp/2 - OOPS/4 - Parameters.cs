using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._2___OOPS
{
    internal class Parameters
    {
        public static void Run()
        {
            //MethodParameters();
            OptionalParameters();
        }

        private static void MethodParameters()
        {
            int a = 5;
            int b = 6;
            int c = Sum(a, b);
            Console.WriteLine(c);
        }

        private static void OptionalParameters()
        {
            int a = 5;
            int b = 6;

            int d = Multiply(a, b);
            int e = Multiply(a);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }

        private static int Multiply(int a, int b = 5)
        {
            return a * b;
        }

        public class User
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public int Age { get; set; }

            public void PrintData()
            {
                Console.WriteLine(Name);
                Console.WriteLine(Email);
                Console.WriteLine(Phone);
                Console.WriteLine(Age);
            }
        }
    }
}
