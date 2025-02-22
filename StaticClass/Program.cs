using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{

    static class Settings
    {
        public static int DayNumber
        {
            get
            {
                return DateTime.Today.Day;
            }
        }

        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }

        public static string ProjectPath
        {
            get;
            set;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Settings.DayNumber);
            Console.WriteLine(Settings.DayName);
        }
    }
}
