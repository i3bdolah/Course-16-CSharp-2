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
            Console.WriteLine("Im Class A !");
        }
        public virtual void PrintNew()
        {
            Console.WriteLine("Im Class A !");
        }

    }

    class clsB : clsA
    {
        public override void PrintOverride()
        {
            Console.WriteLine("Im Class B !");
        }
        public new void PrintNew()
        {
            Console.WriteLine("Im Class B !");
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

