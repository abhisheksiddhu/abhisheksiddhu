using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._2___OOPS
{
    internal class Modifiers
    {
        public static void Run()
        {
            //PrivateModifier();
            //AccessMethods();
            SubClass();
        }

        private static void PrivateModifier()
        {
            User3 user3 = new User3();
            user3.Name = "Test Name";
            user3.PrintData();
        }

        private static void AccessMethods()
        {
            User3 user3 = new User3();
            Console.WriteLine(user3.GetAge());
            Console.WriteLine(user3.Phone);
        }

        private static void SubClass()
        {
            User4 user4 = new User4();
            user4.Name = "Test Name";
            user4.PrintData();
        }

        public class User4
        {
            public string Name { get; set; }
            public string Phone { get; set; }

            public void PrintData()
            {
                Console.WriteLine(Name);
                Console.WriteLine(Phone);
            }
        }
    }

    public class User3
    {
        public string Name;
        private string Password;
        protected string Email;
        internal string UserName;

        private int Age;

        public string Phone { get; protected set; }

        public User3()
        {
            Name = "Default Name";
            Email = "Default Email";
            SetAge(18);
            Phone = "1234567890";
        }

        public void PrintData()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Password);
            Console.WriteLine(Email);
            Console.WriteLine(UserName);
            Console.WriteLine(Age);
            Modifiers.User4 user4 = new Modifiers.User4();
        }

        public int GetAge()
        {
            return Age;
        }

        private void SetAge(int value)
        {
            Age = value;
        }
    }
}
