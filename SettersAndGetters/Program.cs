using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SettersAndGetters
{
    class clsPerson
    {
        private int _id = 3;
        private string _name;
        private int _age;

        public int id { get; }
        public string name { set; get; }
        public int age { set; get; }

        public void printDetails()
        {
            Console.WriteLine("ID   : " + this.id);
            Console.WriteLine("Name : " + this.name);
            Console.WriteLine("Age  : " + this.age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson person1 = new clsPerson();

            //person1.id = 1;
            person1.name = "Abdullah Ban";
            person1.age = 24;

            Console.WriteLine("ID   : " + person1.id);
            Console.WriteLine("Name : " + person1.name);
            Console.WriteLine("Age  : " + person1.age);

        }
    }
}
