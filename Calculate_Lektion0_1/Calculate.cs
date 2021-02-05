using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate_Lektion0_1
{
    public class Calculate
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
                throw new DivideByZeroException("Cannot divide by zero");
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x,exp);
        }
    }
}
