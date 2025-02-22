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

        public int id
        {
            get
            {
                return _id;
            }
        }
        public string name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }
        public int age
        {
            set
            {
                _age = value;
            }
            get
            {
                return _age;
            }
        }

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
