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

        public double Power(double x, double exp)
        {
            return Math.Pow(x,exp);
        }
    }
}
