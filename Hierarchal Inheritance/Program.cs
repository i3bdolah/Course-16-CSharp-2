using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchal_Inheritance
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public void PersonInfo()
        {
            Console.WriteLine($"My name is {name}, and I'm {age} years old.");
        }
    }

    class Employee : Person
    {
        public string highestDegree { get; set; }
        public int yearsOfExp { get; set; }

        public void EmployeeInfo()
        {
            Console.WriteLine($"I'm {name}. I earned {highestDegree} degree, and I have {yearsOfExp} years in the field.");
        }
    }

    class User : Person
    {
        public string interest { get; set; }

        public void UserInfo()
        {
            Console.WriteLine($"I'm {name}, interested in {interest}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.name = "Abdullah";
            employee.age = 24;

            employee.highestDegree = "Bachelor";
            employee.yearsOfExp = 3;

            employee.PersonInfo();
            employee.EmployeeInfo();

            User user = new User();
            user.name = "Mazen";
            user.age = 18;

            user.interest = "Politics";

            user.PersonInfo();
            user.UserInfo();
        }
    }
}
