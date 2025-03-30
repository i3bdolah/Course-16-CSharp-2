using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    public interface IPerson
    {
        int NationalID { set; get; }
        string fName { set; get; }
        string lName { set; get; }
        int Age { set; get; }
        int Birthday { set; get; }
        float Weight { set; get; }
        float Height { set; get; }

        void Print();
    }

    public abstract class Person : IPerson
    {
        public abstract int NationalID { get; set; }
        public abstract string fName { get; set; }
        public abstract string lName { get; set; }
        public abstract int Age { get; set; }
        public abstract int Birthday { get; set; }
        public abstract float Weight { get; set; }
        public abstract float Height { get; set; }

        public void Print()
        {
            Console.WriteLine("Hi");
        }
    }

    public class clsPerson : Person
    {
        public override int NationalID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string fName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string lName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Birthday { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override float Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override float Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson person = new clsPerson();
            person.Print();
        }
    }
}
