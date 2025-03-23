using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MultiLevelInheritance
{

    class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public void PersonInfo()
        {
            Console.WriteLine("مرحبًا، أنا {0}. أبلغ من العمر {1} عامًا.", name, age);
        }
    }

    class Employee : Person
    {
        public string highestDegree { get; set; }
        public int yearsOfExp { get; set; }

        public void EmployeeInfo()
        {
            Console.WriteLine("مرحبًا، أنا {0}. حصلت على شهادة {1}. ولدي {2} سنين من الخبرة.", name, highestDegree, yearsOfExp);
        }
    }

    class Doctor : Employee
    {
        public string specialty { get; set; }

        public void DoctorInfo()
        {
            Console.WriteLine("مرحبًا، أنا {0}. حصلت على شهادة {1}. ولدي {2} سنين من الخبرة. ومتخصص في {3}.", name, highestDegree, yearsOfExp, specialty);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor persona = new Doctor();
            persona.name = "عبدالله";
            persona.age = 24;
            persona.highestDegree = "الباكالوريوس";
            persona.yearsOfExp = 3;
            persona.specialty = "الجلديَّة";

            persona.PersonInfo();
            persona.EmployeeInfo();
            persona.DoctorInfo();
        }
    }
}
