using Microsoft.VisualStudio.TestTools.UnitTesting;

using Web_API_Lib;
using System;

namespace Web_API_Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        [DataRow(30, 10, 20)]
        [DataRow(40.0, 20.0, 20.0)]
        public void CalculatorCanAddTwoPositiveNumbers(double expectedResult, double left, double right)
        {
         
            double result = Calculator.Add(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-30, -10, -20)]
        [DataRow(-20.0, -10.0, -10.0)]
        public void CalculatorCanAddTwoNegativeNumbers(double expectedResult, double left, double right)
        {
            double result = Calculator.Add(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(0, -1.5, 1.5)]
        [DataRow(-10, -20, 10)]
        public void CalculatorCanAddNegativeAndPositiveValues(double expectedResult, double left, double right)
        {
            double result = Calculator.Add(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(2.2, 0, 2.2)]
        [DataRow(10, 0, 10)]
        public void CalculatorCanAddZeroAndPositiveValue(double expectedResult, double left, double right)
        {
            double result = Calculator.Add(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-2, 0, -2)]
        [DataRow(-10.3, 0, -10.3)]
        public void CalculatorCanAddZeroAndNegativeValue(double expectedResult, double left, double right)
        {
            double result = Calculator.Add(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        // Test cases for Substraction

        [TestMethod]
        [DataRow(-10, 10, 20)]
        [DataRow(0.0, 20.0, 20.0)]
        public void CalculatorCanSubtractTwoPositiveNumbers(double expectedResult, double left, double right)
        {

            double result = Calculator.Subtract(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(10, -10, -20)]
        [DataRow(-20.0, -30.0, -10.0)]
        public void CalculatorCanSubtractTwoNegativeNumbers(double expectedResult, double left, double right)
        {
            double result = Calculator.Subtract(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-3, -1.5, 1.5)]
        [DataRow(-30, -20, 10)]
        public void CalculatorCanSubtractNegativeAndPositiveValues(double expectedResult, double left, double right)
        {
            double result = Calculator.Subtract(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-2.2, 0, 2.2)]
        [DataRow(-10, 0, 10)]
        public void CalculatorCanSubtractZeroAndPositiveValue(double expectedResult, double left, double right)
        {
            double result = Calculator.Subtract(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(2, 0, -2)]
        [DataRow(10.3, 0, -10.3)]
        public void CalculatorCanSubtractZeroAndNegativeValue(double expectedResult, double left, double right)
        {
            double result = Calculator.Subtract(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        // Test cases for Multiplication

        [TestMethod]
        [DataRow(200, 10, 20)]
        [DataRow(400.0, 20.0, 20.0)]
        public void CalculatorCanMultiplyTwoPositiveNumbers(double expectedResult, double left, double right)
        {

            double result = Calculator.Multiply(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(200, -10, -20)]
        [DataRow(300.0, -30.0, -10.0)]
        public void CalculatorCanMultiplyTwoNegativeNumbers(double expectedResult, double left, double right)
        {
            double result = Calculator.Multiply(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-2.25, -1.5, 1.5)]
        [DataRow(-200, -20, 10)]
        public void CalculatorCanMultiplyNagativeAndPositiveValues(double expectedResult, double left, double right)
        {
            double result = Calculator.Multiply(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(0, 0, 2.2)]
        [DataRow(0, 0, 10)]
        public void CalculatorCanMultiplyZeroPlusPositiveValue(double expectedResult, double left, double right)
        {
            double result = Calculator.Multiply(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(0, 0, -2)]
        [DataRow(0, 0, -10.3)]
        public void CalculatorCanMultiplyZeroPlusNegativeValue(double expectedResult, double left, double right)
        {
            double result = Calculator.Multiply(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        // Test cases for Division

        [TestMethod]
        [DataRow(0.5, 10, 20)]
        [DataRow(1, 20.0, 20.0)]
        public void CalculatorCanDivideTwoPositiveNumbers(double expectedResult, double left, double right)
        {

            double result = Calculator.Divide(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(0.5, -10, -20)]
        [DataRow(3, -30.0, -10.0)]
        public void CalculatorCanDivideTwoNegativeNumbers(double expectedResult, double left, double right)
        {
            double result = Calculator.Divide(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-1, -1.5, 1.5)]
        [DataRow(-2, -20, 10)]
        public void CalculatorCanDivideNegativeAndPositiveValues(double expectedResult, double left, double right)
        {
            double result = Calculator.Divide(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(0, 0, 2.2)]
        [DataRow(0, 0, -10.3)]
        public void CalculatorCanDivideZeroAndPositiveOrNegativeValue(double expectedResult, double left, double right)
        {
            double result = Calculator.Divide(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(8, 8, 1)]
        public void CalculatorDividesPositiveNumbersWithDenominatorGreaterThanZero(double expectedResult, double left, double right)
        {
            double result = Calculator.Divide(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CalculatorThrowsExceptionWhenDividingByZero()
        {
            Assert.ThrowsException<DivideByZeroException>(() => { Calculator.Divide(6, 0); });
        }


    }
}
