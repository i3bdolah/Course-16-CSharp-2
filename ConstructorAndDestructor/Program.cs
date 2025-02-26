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


        // This is how the (Constructor) is behind the scenes!
        //public clsEmployee()
        //{
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployee employee = new clsEmployee(158, "Abdullah", "Software Engineer");
            Console.WriteLine(employee.Id);
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Description);
        }
    }
}
