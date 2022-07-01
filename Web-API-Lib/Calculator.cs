using System;

namespace Web_API_Lib
{
    public class Calculator
    {
        double Add(double left, double right)
        {
            return left + right;
        }

        double Subtraction(double left, double right)
        {
            return left - right;
        }

        double Multiplication(double left, double right)
        {
            return left * right;
        }

        double Division(double left, double right)
        {
            return left / right;
        }
    }
}
