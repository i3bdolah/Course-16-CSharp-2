using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{

    abstract class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public void PersonInfo()
        {
            Console.WriteLine($"My name is {name}, and I'm {age} years old.");
        }

        abstract public void SayHi();
    }

    class Employee : Person
    {
        public int EmpID;

        public override void SayHi()
        {
            Console.WriteLine($"Hi, I'm employee number {this.EmpID}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();

            Employee emp = new Employee();
            emp.name = "Abdullah";
            emp.age = 24;
            emp.EmpID = 0;
            emp.PersonInfo();
            emp.SayHi();
        }
    }
}
