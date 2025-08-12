using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethods
{
    public partial class Person
    {
        public int Age { get; set; }
        partial void PrintAge();
        public void Birthday()
        {
            Age++;
            // ·Ê „ﬂ Ê»… ” ŸÂ— ‰ ÌÃ…° Ê≈·« ”  Ã«Â·
            PrintAge();
        }
    }
}
