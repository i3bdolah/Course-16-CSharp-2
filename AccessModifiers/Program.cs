using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        class clsA
        {
            public string publicA = "I'm publicA value";
            protected string protectedB = "I'm protectedB value";
            private string privateC = "I'm privateC value";
        }

        class clsB : clsA
        {
            public string GettingProtectedB()
            {

                return protectedB;
            }
        }
        static void Main(string[] args)
        {
            clsA FirstCls = new clsA();

            Console.WriteLine(FirstCls.publicA);

            clsB SecondCls = new clsB();

            Console.WriteLine(SecondCls.GettingProtectedB());
        }
    }
}
