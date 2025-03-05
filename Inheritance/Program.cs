using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class clsPerson
    {
        public clsPerson(int ID, string FirstName, string LastName, string Title)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Title = Title;
        }

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
        public clsEmployee(float Salary, string DepartmentName, // معاملات الفئة المشتقة
            int ID, string FirstName, string LastName, string Title) // معاملات الفئة الأساسية
            : base(ID, FirstName, LastName, Title) // تهريب أو تمرير معاملات الفئة الأساسية
        {
            this.Salary = Salary;
            this.DepartmentName = DepartmentName;
        }


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
