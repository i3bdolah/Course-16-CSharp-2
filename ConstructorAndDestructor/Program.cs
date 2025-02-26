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
            Id = 1;
            Name = "Unknown";
            Description = "Unknown";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployee employee = new clsEmployee();
            Console.WriteLine(employee.Id);
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Description);
        }
    }
}
