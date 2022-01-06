using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.OOPS
{
    public class Basics
    {
        public static void Process()
        {
            User user1 = new User();
            user1.Abcdegf();
            user1.Name = "Abhishek";
            user1.Abcdegf();
            user1.Name = "Abhishek2";
            user1.Email = "abhi@email";

            User user2 = new User();
            user2.Abcdegf();
            user2.Name = "Govind";
            user2.Email = "govind@email";


            user2.Abcdegf();
            user1.Abcdegf();
        }
    }

    public class User
    {
        public string Name;
        public string Password;
        public string Email;
        public string UserName;

        public User()
        {
            Name = "Default Name";
            Password = "Default Password";
            Email = "Default Email";
            UserName = "Default UserName";
        }

        public void Abcdegf()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Password: " + Password);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("UserName: " + UserName);
            Console.WriteLine();
        }
    }
}
