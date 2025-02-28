using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndDestructor
{

    //static class Settings
    class Settings
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

        //private Settings()
        //{

        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings aa = new Settings();

            Console.WriteLine(Settings.DayNumber);
            Console.WriteLine(Settings.DayName);
        }
    }
}
