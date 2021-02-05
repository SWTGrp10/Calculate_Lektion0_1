using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate_Lektion0_1
{
    public class Calculate
    {
        public double Accumulator { get; set; }

        public void Clear()
        {
            Accumulator = 0;
        }


        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }


        public double Add(double b)
        {
            Accumulator += b;
            return Accumulator;
        }


        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }


        public double Subtract( double b)
        {
            Accumulator -= b;
            return Accumulator;
        }


        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Multiply(double b)
        {
            Accumulator = Accumulator * b;
            return Accumulator;
        }

        public double Divide(double a, double b)
        {
            if (b != 0)
            {
                Accumulator = a / b;
                return Accumulator;
            }
            else
                throw new DivideByZeroException("Cannot divide by zero");
        }
        public double Divide(double b)
        {
            if (b != 0)
            {
                Accumulator = Accumulator / b;
                return Accumulator;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }

        public double Power(double exp)
        {
            Accumulator = Math.Pow(Accumulator, exp);
            return Accumulator;
        }
    }
}
