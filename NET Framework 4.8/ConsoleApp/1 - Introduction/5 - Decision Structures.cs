using System;

namespace ConsoleApp._1___Introduction
{
    internal class DecisionStructures
    {
        public static void Run()
        {
            //SingleIfElse();
            //ExtendedIfElse();
            SwitchExec();
        }

        public static void SingleIfElse()
        {
            int a = 5;
            ConditionalPrint(a);
            int b = 16;
            ConditionalPrint(b);
        }

        public static void ConditionalPrint(int value)
        {
            if (value > 10)
            {
                Console.WriteLine("Greater Value: " + value);
            }
            else
            {
                Console.WriteLine("Smaller Value: " + value);
            }
        }

        public static void ExtendedIfElse()
        {
            int a = 5;
            ExtendedConditionalPrint(a);
            a = 16;
            ExtendedConditionalPrint(a);
            a = 26;
            ExtendedConditionalPrint(a);
        }

        public static void ExtendedConditionalPrint(int value)
        {
            if (value > 10)
            {
                Console.WriteLine("Greater Value: " + value);
            }
            else if (value > 20)
            {
                Console.WriteLine("Bigger Value: " + value);
            }
            else
            {
                Console.WriteLine("Smaller Value: " + value);
            }

            if (value > 20)
            {
                Console.WriteLine("Bigger Value: " + value);
            }
        }

        public static void SwitchExec()
        {
            string a = "hello";
            SwitchPrint(a);
            a = "world";
            SwitchPrint(a);
            a = "universe";
            SwitchPrint(a);
            a = "test";
            SwitchPrint(a);
            a = "rfgrfg";
            SwitchPrint(a);
        }

        public static void SwitchPrint(string value)
        {
            switch (value)
            {
                case "hello":
                    {
                        Console.WriteLine("First");
                        break;
                    }
                case "world":
                case "universe":
                    {
                        Console.WriteLine("Second");
                        break;
                    }
                case "test":
                    {
                        Console.WriteLine("Third");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Empty");
                        break;
                    }
            }
        }
    }
}
