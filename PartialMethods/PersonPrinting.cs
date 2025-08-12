using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethods
{
    partial class Person
    {
        partial void PrintAge()
        {
            Console.WriteLine("Current Age: {0}", Age);
        }
    }
}
