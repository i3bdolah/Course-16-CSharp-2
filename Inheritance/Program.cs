using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class clsPerson
    {
        //properties
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        public string FullName
        {
            // read-only property
            get { return FirstName + " " + LastName; }
        }
    }

    public class clsEmployee : clsPerson
    {
        //properties
        public float Salary { set; get; }
        public string DepartmentName { get; set; }

        //method
        public void IncreaseSalary(float addition) { Salary += addition; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployee emp = new clsEmployee();

            emp.ID = 1;
            emp.FirstName = "Abdullah";
            emp.LastName = "Al-Shehri";
            emp.Salary = 8228;
            emp.DepartmentName = "Business Applications";


            Console.WriteLine("ID               :   " + emp.ID);
            Console.WriteLine("FirstName        :   " + emp.FirstName);
            Console.WriteLine("LastName         :   " + emp.LastName);
            Console.WriteLine("Salary           :   " + emp.Salary);
            Console.WriteLine("DepartmentName   :   " + emp.DepartmentName);
            Console.WriteLine();
            Console.WriteLine("After calling IncreaseSalary(10000)");
            emp.IncreaseSalary(10000);
            Console.WriteLine();
            Console.WriteLine("Salary           :   " + emp.Salary);
        }
    }
}
