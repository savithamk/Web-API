using System;

namespace Web_API_Lib
{
    public class Calculator
    {
        //To add two numbers
        public static double Add(double left, double right)
        {
            return left + right;
        }

        //To subtract two numbers
        public static double Subtract(double left, double right)
        {
            return left - right;
        }

        //To multiply two numbers
        public static double Multiply(double left, double right)
        {
            return left * right;
        }

        //To divide two numbers
        public static double Divide(double left, double right)
        {
            if(right != 0)
            {
                return left / right;
            }
            else
            {
                throw new DivideByZeroException();
            }
        }
    }
}
