using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingAndDowncasting
{

    class Person
    {
        public string name;
        public int age;

        public void Greet()
        {
            Console.WriteLine("My name is {0}, I'm {1} years old.", name, age);
        }
    }

    class Employee : Person
    {
        public string company;
        public int salary;

        public void Work()
        {
            Console.WriteLine("Im currently working at {0}, and I earn {1} per month.", company, salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "Abdullah";
            person.age = 24;

            person.Greet();

            Employee emp = new Employee();
            emp.name = "Abdullah";
            emp.age = 24;
            emp.company = "NTIS";
            emp.salary = 8109;

            emp.Work();

            // تحويل الكائن الإبن إلى كائن من الأب - Upcasting
            Person upcastedEmp = emp;

            upcastedEmp.Greet();

            // تحويل الكائن الأب إلى كائن من الإبن- Downcasting
            //Employee downcastedPer = (Employee)person; // Error
            Person per2 = new Employee { name = "Abdullah", age = 23, company = "NTIS", salary = 1000 };
            Employee downcastedPer = (Employee)per2;

            Console.WriteLine("");
            Console.WriteLine("downcastedPer :");
            Console.WriteLine("");

            downcastedPer.Greet();
        }
    }
}
