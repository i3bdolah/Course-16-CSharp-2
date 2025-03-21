using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{

    class clsA
    {
        public virtual void PrintOverride()
        {
            Console.WriteLine("Im The BASE Class");
        }
        public virtual void PrintNew()
        {
            Console.WriteLine("Im The BASE Class");
        }

    }

    class clsB : clsA
    {
        public override void PrintOverride()
        {
            Console.WriteLine("Derived Class Implemented By OVERRIDE");
        }
        public new void PrintNew()
        {
            Console.WriteLine("Derived Class Implemented By NEW");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            clsA a = new clsB();

            a.PrintOverride();

            a.PrintNew();

        }
    }
}

