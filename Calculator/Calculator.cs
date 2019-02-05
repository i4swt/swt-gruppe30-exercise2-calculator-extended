using System;

namespace Calculator
{
    public class Calculator
    {
        public Calculator()
        {
            Clear();
        }
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Accumulator { get; private set; }

        public double Add(double addend)
        {
            Accumulator += addend;
            return Accumulator;
        }

        public double Subtract(double subtractor)
        {
            Accumulator -= subtractor;
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }

    }
}