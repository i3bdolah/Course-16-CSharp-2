using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClasses
{

    public class clsOuter
    {
        public int OuterVar;

        public clsOuter(int OuterVar)
        {
            this.OuterVar = OuterVar;
        }

        public void OuterMethod()
        {
            Console.WriteLine("Im the outer method with variable: " + OuterVar);
        }

        public class clsInner { 

            public int InnerVar;

            public clsInner(int InnerVar)
            {
                this.InnerVar = InnerVar;
            }

            public void InnerMethod()
            {
                Console.WriteLine("Im the inner method with variable: " + InnerVar);
            }

            public void AccessOuterVar(clsOuter outer)
            {
                Console.WriteLine("the outer variable from inner: " + outer.OuterVar);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            clsOuter outer = new clsOuter(1);
            outer.OuterMethod();

            clsOuter.clsInner inner = new clsOuter.clsInner(2);
            inner.InnerMethod();
            inner.AccessOuterVar(outer);
        }
    }
}
