﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndDestructor
{

    class Settings
    {

        //this is a static constructor will be called once during the program
        static Settings()
        {
            Console.WriteLine("Im Static Constractor");
        }

        public Settings()
        {
            Console.WriteLine("Im Not Static Constractor");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Settings settings1 = new Settings();
            Settings settings2 = new Settings();
            Settings settings3 = new Settings();
            Settings settings4 = new Settings();
        }
    }
}
