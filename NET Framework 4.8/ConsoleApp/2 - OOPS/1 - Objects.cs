using System;

namespace ConsoleApp._2___OOPS
{
    internal class Objects
    {
        public static void Run()
        {

        }

        public static void ObjectCreationAndAccess()
        {
            User1 user1 = new User1
            {
                Name = "Abhishek",
                Email = "abhi@email"
            };

            Console.WriteLine(user1.Name);
            Console.WriteLine(user1.Email);

            User1 user2 = new User1
            {
                Name = "Govind",
                Email = "govind@email"
            };

            Console.WriteLine(user2.Name);
            Console.WriteLine(user2.Email);
        }

        public static void Equality()
        {
            int a = 1;
            int b = 1;
            Console.WriteLine(a == b);


            User1 user1 = new User1
            {
                Name = "Abhishek"
            };

            User1 user2 = new User1
            {
                Name = "Abhishek"
            };

            Console.WriteLine(user1 == user2);
            Console.WriteLine(user1.Name == user2.Name);
        }

        public static void ValueOrReferenceType()
        {
            int a = 1;
            int b = a;

            Console.WriteLine(a == b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 5;

            Console.WriteLine(a == b);
            Console.WriteLine(a);
            Console.WriteLine(b);


            User1 user1 = new User1
            {
                Name = "Abhishek"
            };

            User1 user2 = user1;

            Console.WriteLine(user1 == user2);
            Console.WriteLine(user1.Name);
            Console.WriteLine(user2.Name);

            user1.Name = "Govind";

            Console.WriteLine(user1 == user2);
            Console.WriteLine(user1.Name);
            Console.WriteLine(user2.Name);
        }
    }

    public class User1
    {
        public string Name;
        public string Password;
        public string Email;
        public string UserName;
    }
}
