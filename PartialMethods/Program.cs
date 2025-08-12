using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 10;
            person.Birthday();
        }
    }
}
