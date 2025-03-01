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

        public clsEmployee(int Id, string Name, string Description)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
        }

        public clsEmployee()
        {
            this.Id = 0;
            this.Name = "Name";
            this.Description = "Description";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployee employee1 = new clsEmployee(158, "Abdullah", "Software Engineer");
            Console.WriteLine(employee1.Id);
            Console.WriteLine(employee1.Name);
            Console.WriteLine(employee1.Description);

            Console.WriteLine();

            clsEmployee employee2 = new clsEmployee();
            Console.WriteLine(employee2.Id);
            Console.WriteLine(employee2.Name);
            Console.WriteLine(employee2.Description);
        }
    }
}
