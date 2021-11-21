using NUnit.Framework;
using System;

namespace calculator.Tests
{
    public class Tests
    {
        private Calculator calculator = new Calculator();

        [TestCase(4, 5, 9)]
        [TestCase(11.2, 0.8, 12)]
        [TestCase(-1, 3, 2)]
        public void SumTest(double x, double y, double result)
        {
            Assert.AreEqual(result, calculator.Sum(x, y));
        }


        [TestCase(4, 5, -1)]
        [TestCase(22.3, 11.5, 10.8)]
        [TestCase(13, -5, 18)]
        public void SubstractTest(double x, double y, double result)
        {
            Assert.AreEqual(result, calculator.Subtract(x, y));
        }


        [TestCase(4, 5, 20)]
        [TestCase(12.5, 0.24, 3)]
        [TestCase(13, -5, -65)]
        public void MultiplyTest(double x, double y, double result)
        {
            Assert.AreEqual(result, calculator.Multiply(x, y));
        }


        [TestCase(10, 2, 5)]
        [TestCase(11.2, 2, 5.6)]
        public void DivideTest(double x, double y, double result)
        {
            Assert.AreEqual(result, calculator.Divide(x, y));
        }

        [TestCase(13, 0)]
        public void DivideTestZeroException(double x, double y)
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(x, y));
        }

        [TestCase(10, 2, 100)]
        [TestCase(6, 4, 1296)]
        [TestCase(13, 0, 1)]
        public void PowTest(double x, double y, double result)
        {
            Assert.AreEqual(result, calculator.Pow(x, y));
        }



    }
}