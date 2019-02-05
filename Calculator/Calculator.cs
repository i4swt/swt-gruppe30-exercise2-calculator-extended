using System;

namespace Calculator
{
    public class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Substract(double a, double b)
        {
            return a - b;
        }

        public static double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Accumulator { get; private set; }

        public static double Add(double addend)
        {
            Accumulator += Accumulator;
            return addend + Accumulator;
        }

        public static double Substract(double substractor)
        {
            Accumulator -= substractor;
            return Accumulator - substractor;
        }

        public static void Clear()
        {
            Accumulator = 0;
        }

    }
}