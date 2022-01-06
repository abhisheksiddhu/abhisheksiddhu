using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Calculator
{
    public class Basic
    {
        public static void Process()
        {
            float result = Calculate();
            Console.WriteLine(result);
        }

        public static float Calculate()
        {
            float a = GetInput();
            float b = GetInput();
            string operand = GetOperator();
            float result = 0;
            switch (operand)
            {
                case "+": result = a + b; break;
                case "-": result = a - b; break;
                case "*": result = a * b; break;
                case "/": result = a / b; break;
                default: break;
            }
            return result;
        }

        public static float GetInput()
        {
            Console.WriteLine("Enter Input");
            string input = Console.ReadLine();
            return float.Parse(input);
        }

        public static string GetOperator()
        {
            Console.WriteLine("Enter operator");
            string input = Console.ReadLine();
            return input;
        }
    }
}
