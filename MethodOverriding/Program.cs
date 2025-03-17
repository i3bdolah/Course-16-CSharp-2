using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{

    class clsA
    {
        public virtual void Print()
        {
            Console.WriteLine("Im Class A !");
        }
    }

    class clsB : clsA
    {
        public override void Print()
        {
            Console.WriteLine("Im Class B !");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            clsA a = new clsB();
            clsA b = new clsA();

            a.Print();
            b.Print();

        }
    }
}
