using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndDestructor
{

    class clsEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public clsEmployee()
        {
            Console.WriteLine("Constructor is Running");
        }

        ~clsEmployee()
        {
            Console.WriteLine("Destructor is Running");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployee employee1 = new clsEmployee();
            clsEmployee employee2 = new clsEmployee();
            clsEmployee employee3 = new clsEmployee();
        }
    }
}
