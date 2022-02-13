using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._2___OOPS
{
    internal class Abstraction
    {
        public static void Run()
        {
            Square a = new Square();
            

        }

        public abstract class Shape
        {
            public void PrintSample()
            {
                Console.WriteLine("Sample");
            }

            public abstract int GetArea();
        }

        public class Square : Shape
        {
            public int Length { get; set; }

            public override int GetArea()
            {
                return Length * Length;
            }
        }

        public class Rectangle : Square
        {
            public int Width { get; set; }

            public override int GetArea()
            {
                return Length * Width;
            }
        }

        public class Circle : Shape
        {
            public int Radius { get; set; }

            public override int GetArea()
            {
                return (int)(Radius * Radius * 3 * Math.PI);
            }
        }
    }
}
