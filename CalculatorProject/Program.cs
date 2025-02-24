using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{

    class clsCalculator
    {
        private string _operationName = "";
        private int _operationValue = 0;

        public int currNum = 0;

        public void PrintResult()
        {
            Console.WriteLine("Result after {0} {1} is : {2}", _operationName, _operationValue, currNum);
        }

        public void Add(int num)
        {
            _operationName = "Adding";
            _operationValue = num;

            currNum += num;
        }

        public void Subtract(int num)
        {
            _operationName = "Subtracting";
            _operationValue = num;

            currNum -= num;
        }

        public void Multiply(int num)
        {
            _operationName = "Multiplying";
            _operationValue = num;

            currNum *= num;
        }

        public void Divide(int num)
        {
            if (num == 0) {
                _operationName = "Dividing";
                _operationValue = num;
                return; 
            }
            _operationName = "Dividing";
            _operationValue = num;

            currNum /= num;
        }

        public void Clear()
        {
            _operationName = "";
            _operationValue = 0;

            currNum = 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsCalculator MyCalculator = new clsCalculator();

            MyCalculator.PrintResult();

            MyCalculator.Clear();
            MyCalculator.PrintResult();

            MyCalculator.Add(100);
            MyCalculator.PrintResult();
            MyCalculator.Subtract(5);
            MyCalculator.PrintResult();
            MyCalculator.Multiply(2);
            MyCalculator.PrintResult();
            MyCalculator.Divide(0);
            MyCalculator.PrintResult();
            MyCalculator.Divide(2);
            MyCalculator.PrintResult();

        }
    }
}
