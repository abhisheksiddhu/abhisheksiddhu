using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._2___OOPS
{
    internal class Constructors
    {
        public static void Run()
        {
            //ObjectConstruction();
            Structures();
        }

        public static void ObjectConstruction()
        {
            User2 user1 = new User2();
            Console.WriteLine(user1.Name);
            Console.WriteLine(user1.Email);

            user1.Name = "New Name";
            Console.WriteLine(user1.Name);
            Console.WriteLine(user1.Email);
        }

        public static void Structures()
        {
            Struct2 struct1 = new Struct2();
            Struct2 struct2 = new Struct2();

            struct1.Name = "Default";
            struct2.Name = "Default";

            Console.WriteLine(struct1.Equals(struct2));
            Console.WriteLine(struct1.Name);
            Console.WriteLine(struct2.Name);

            struct1.Name = "Test";

            Console.WriteLine(struct1.Equals(struct2));
            Console.WriteLine(struct1.Name);
            Console.WriteLine(struct2.Name);
        }
    }

    public class User2
    {
        public string Name;
        public string Password;
        public string Email;
        public string UserName;

        public User2()
        {
            Name = "Default Name";
        }
    }

    public struct Struct2
    {
        public string Name;
        public string Password;
        public string Email;
        public string UserName;

        public Struct2(string name, string password, string email, string username)
        {
            Name = name;
            Password = password;
            Email = email;
            UserName = username;
        }
    }
}
