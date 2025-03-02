using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationOfUsingStaticAndConstructors
{
    internal class Program
    {

        class clsPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }

            public clsPerson(int id, string name, int age)
            {
                // أنا لا أريد أجبار المستخدم على إدخال كل البيانات، لأن هذا غير متاح في معظم الحالات
                Id = id;
                Name = name;
                Age = age;
            }

            public static clsPerson Find(int Id)
            {
                if (Id == 10) return new clsPerson(10, "Abdullah Al-Shehri", 24);
                else return null;
            }

            public static clsPerson Find(string Username, string Password)
            {
                if (Username == "user" && Password == "1234") return new clsPerson(10, "Abdullah Al-Shehri", 24);
                else return null;
            }
        }

        static void Main(string[] args)
        {
            clsPerson person1 = clsPerson.Find(10);

            if (person1 != null)
            {
                Console.WriteLine("Id : " + person1.Id);
                Console.WriteLine("Name : " + person1.Name);
                Console.WriteLine("Age : " + person1.Age);
            }
            else
            {
                Console.WriteLine("Sorry, We couldn't find the desired object.");
            }


            Console.WriteLine("----------------------------------");

            clsPerson person2 = clsPerson.Find("user", "1234");

            if (person2 != null)
            {
                Console.WriteLine("Id : " + person2.Id);
                Console.WriteLine("Name : " + person2.Name);
                Console.WriteLine("Age : " + person2.Age);
            }
            else
            {
                Console.WriteLine("Sorry, We couldn't find the desired object.");
            }
        }
    }
}
