using Microsoft.VisualStudio.TestTools.UnitTesting;

using Web_API_Lib;

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
        public void CalculatorCanAddTwoNegetiveNumbers(double expectedResult, double left, double right)
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
        public void CalculatorCanAddZeroPlusPositiveValue(double expectedResult, double left, double right)
        {
            double result = Calculator.Add(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-2, 0, -2)]
        [DataRow(-10.3, 0, -10.3)]
        public void CalculatorCanAddZeroPlusNegetiveValue(double expectedResult, double left, double right)
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

            double result = Calculator.Subtraction(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(10, -10, -20)]
        [DataRow(-20.0, -30.0, -10.0)]
        public void CalculatorCanSubtractTwoNegetiveNumbers(double expectedResult, double left, double right)
        {
            double result = Calculator.Subtraction(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-3, -1.5, 1.5)]
        [DataRow(-30, -20, 10)]
        public void CalculatorCanSubtractNegativeAndPositiveValues(double expectedResult, double left, double right)
        {
            double result = Calculator.Subtraction(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-2.2, 0, 2.2)]
        [DataRow(-10, 0, 10)]
        public void CalculatorCanSubtractZeroPlusPositiveValue(double expectedResult, double left, double right)
        {
            double result = Calculator.Subtraction(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(2, 0, -2)]
        [DataRow(10.3, 0, -10.3)]
        public void CalculatorCanSubtractZeroPlusNegetiveValue(double expectedResult, double left, double right)
        {
            double result = Calculator.Subtraction(left, right);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

    }
}
