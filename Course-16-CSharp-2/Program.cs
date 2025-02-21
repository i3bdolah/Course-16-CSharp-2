using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_16_CSharp_2
{
    internal class Program
    {
        class clsPerson
        {
            // Fields
            public bool IsSaeed;
            public string FirstName;
            public string LastName;

            // Methods
            public void GetFullName()
            {
                System.Console.WriteLine(this.FirstName + " " + this.LastName);
            }
        }
        static void Main(string[] args)
        {
            clsPerson Abdullah = new clsPerson();

            Abdullah.IsSaeed = true; // بإذن الله أكون من السعداء
            Abdullah.FirstName = "Abdullah";
            Abdullah.LastName = "Al-Shehri";

            Abdullah.GetFullName();
        }
    }
}
