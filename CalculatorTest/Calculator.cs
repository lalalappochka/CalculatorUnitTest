using Xunit;
using System;

namespace calculator.Tests
{
    
    public class Tests
    {
       public Tests()
        {
            calculator = new Calculator();
        }
        private Calculator calculator;

        [Theory]
        [InlineData(4, 5, 9)]
        [InlineData(11.2, 0.8, 12)]
        [InlineData(-1, 3, 2)]
        public void SumTest(double x, double y, double result)
        {
            Assert.Equal(result, calculator.Sum(x, y));
        }

        [Theory]
        [InlineData(4, 5, -1)]
        [InlineData(22.3, 11.5, 10.8)]
        [InlineData(13, -5, 18)]
        public void SubstractTest(double x, double y, double result)
        {
            Assert.Equal(result, calculator.Subtract(x, y));
        }

        [Theory]
        [InlineData(4, 5, 20)]
        [InlineData(12.5, 0.24, 3)]
        [InlineData(13, -5, -65)]
        public void MultiplyTest(double x, double y, double result)
        {
            Assert.Equal(result, calculator.Multiply(x, y));
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(11.2, 2, 5.6)]
        public void DivideTest(double x, double y, double result)
        {
            Assert.Equal(result, calculator.Divide(x, y));
        }

        [Theory]
        [InlineData(13, 0)]
        public void DivideTestZeroException(double x, double y)
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(x, y));
        }

        [Theory]
        [InlineData(10, 2, 100)]
        [InlineData(6, 4, 1296)]
        [InlineData(13, 0, 1)]
        public void PowTest(double x, double y, double result)
        {
            Assert.Equal(result, calculator.Pow(x, y));
        }



    }
}