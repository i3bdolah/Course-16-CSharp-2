using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{

    public class clsA
    {
        public virtual void Print()
        {
            Console.WriteLine("Im Printing from clsA");
        }
    }

    public class clsB : clsA
    {
        public sealed override void Print()
        {
            Console.WriteLine("Im Printing from clsB");
        }

    }

    public class clsC : clsB
    {
        //public override void Print()
        //{
        //    Console.WriteLine("Im Printing from clsB");
        //}
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            clsA clsA = new clsA();
            clsA.Print();

            clsB clsB = new clsB();
            clsB.Print();

            clsC clsC = new clsC();
            clsC.Print();
        }
    }
}
