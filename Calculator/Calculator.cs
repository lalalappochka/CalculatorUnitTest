using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Calculator
    {
        public double Sum(double x, double y)
        {
            return x + y;
        }
        public double Subtract(double x, double y)
        {
            return x - y;
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }
        public double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Divided by zero exception");
            }
            return x / y;
        }
        public double Pow(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}

