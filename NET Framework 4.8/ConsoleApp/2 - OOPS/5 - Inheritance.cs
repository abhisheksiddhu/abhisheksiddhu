using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._2___OOPS
{
    internal class Inheritance
    {
        public static void Run()
        {
            //InheritProperties();
            InheritMethods();
        }

        private static void InheritProperties()
        {
            Student s = new Student
            {
                Name = "Default Name",
                ClassRoom = 5
            };

            Teacher t = new Teacher
            {
                Name = "Teacher",
                Salary = 10
            };

            User u = new User
            {
                Name = "User"
            };

            PassUser(s);
            PassUser(t);
            PassUser(u);
        }

        private static void InheritMethods()
        {
            Student s = new Student
            {
                Name = "Default Name",
                ClassRoom = 5
            };

            Teacher t = new Teacher
            {
                Name = "Teacher",
                Salary = 10
            };

            User u = new User
            {
                Name = "User"
            };

            s.PrintData();
            t.PrintData();
            u.PrintData();
        }

        private static void PassUser(User s)
        {
            User user = s;
            Console.WriteLine(user.Name);
            //user.Phone = "";
        }

        public class User
        {
            public string Name { get; set; }
            private string Email { get; set; }
            protected string Phone { get; set; }

            public User()
            {
                Email = "abc@xyz";
            }

            public virtual void PrintData()
            {
                Console.WriteLine(Name);
                Console.WriteLine(Email);
                Console.WriteLine(Phone);
            }
        }

        public class Student : User
        {
            public int ClassRoom { get; set; }

            public Student()
            {
                //Email = "";
                Phone = "Student 1234567890";
            }

            public override void PrintData()
            {
                base.PrintData();
                Console.WriteLine(ClassRoom);
            }
        }

        public class Teacher : User
        {
            public int Salary { get; set; }

            public Teacher()
            {
                //Email = "";
                Phone = "Teacher 1234567890";
            }
            public override void PrintData()
            {
                base.PrintData();
                Console.WriteLine(Salary);
            }
        }
    }
}
