using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{

    public class clsA
    {
        public void MyMethod()
        {
            Console.WriteLine("Im the method of clsA");
        }
    }

    public class clsB
    {
        public void MyMethod()
        {
            clsA classA = new clsA();
            Console.WriteLine("From class B");
            classA.MyMethod();
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            clsA clsA = new clsA();
            clsA.MyMethod();

            clsB clsB = new clsB();
            clsB.MyMethod();
        }
    }
}
