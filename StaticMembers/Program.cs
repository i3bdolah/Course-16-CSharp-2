using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    internal class Program
    {
        class clsA
        {
            public int myAge = 24;
            public static int averagePeopleAge = 37;

            public void printMyAge()
            {
                Console.WriteLine(myAge + " years.");
            }

            public static void printAvgAge()
            {
                Console.WriteLine(averagePeopleAge + " years.");
            }
        }
        static void Main(string[] args)
        {
            clsA myClass1 = new clsA();
            clsA myClass2 = new clsA();
            myClass1.myAge = 25;
            myClass2.myAge = 26;

            Console.WriteLine(myClass1.myAge);
            Console.WriteLine(myClass2.myAge);
            Console.WriteLine(clsA.averagePeopleAge);

            clsA.averagePeopleAge = 0;

            Console.WriteLine(clsA.averagePeopleAge);

        }
    }
}
