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
            //InBuiltDataTypes();
            //TypeConversion();
            //TypeArithmetics();
            //StringRepresentation();
            StringParsing();
        }

        public static void InBuiltDataTypes()
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

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.Ticks);
        }

        public static void TypeConversion()
        {
            // Type Casting
            int a = 5;
            float b = 6.2F;
            float c = (float)a + b;
            int d = a + (int)b;

            Console.WriteLine(c);
            Console.WriteLine(d);

            Int32 e = -5;
            uint f = Convert.ToUInt32(e);
            Console.WriteLine(e);
            Console.WriteLine(f);

            char x = 'a';
            String y = "hello";
            String z = x + y;
        }

        public static void TypeArithmetics()
        {
            int a = 5;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);

            string d = "hello";
            string e = "hello";
            string f = d + e;
            Console.WriteLine(f);

            Console.WriteLine(f + c);
        }

        public static void StringRepresentation()
        {
            int a = 5555;
            byte[] b = BitConverter.GetBytes(a).Reverse().ToArray();
            PrintByteArrayAsString(b);

            string c = "5555";
            byte[] d = Encoding.Unicode.GetBytes(c);
            PrintByteArrayAsString(d);

            string e = 5555.ToString();
            byte[] f = Encoding.Unicode.GetBytes(e);
            PrintByteArrayAsString(f);
        }

        public static void PrintByteArrayAsString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
            {
                hex.Append(Convert.ToString(b, 2).PadLeft(8, '0') + " ");
            }

            string s = hex.ToString();
            Console.WriteLine(s);
        }

        public static void StringParsing()
        {
            string a = "5";
            int b = int.Parse(a);
            Console.WriteLine(b);

            string c = "52.37";
            float d = float.Parse(c);
            Console.WriteLine(d);

            string e = "2012-10-21";
            DateTime f = DateTime.Parse(e);
            Console.WriteLine(f.Year);

            //string y = "hello";
            //int z = int.Parse(y);
            //Console.WriteLine(z);
        }
    }
}
