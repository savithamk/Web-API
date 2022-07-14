using System;

namespace Web_API_Lib
{
    public class Calculator
    {
        public static double Add(double left, double right)
        {
            return left + right;
        }

        public static double Subtraction(double left, double right)
        {
            return left - right;
        }

        public static double Multiplication(double left, double right)
        {
            return left * right;
        }

        public static double Division(double left, double right)
        {
            return left / right;
        }
    }
}
