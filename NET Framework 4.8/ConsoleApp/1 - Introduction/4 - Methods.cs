﻿using System;

namespace ConsoleApp._1___Introduction
{
    internal class Methods
    {
        public static void Run()
        {
            int a = 5;
            int b = 8;
            int c = Add(a, b);
            Console.WriteLine(c);
        }

        public static int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }


    }
}
