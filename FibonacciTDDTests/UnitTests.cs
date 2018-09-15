using FibonacciTDD.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace FibonacciTDDTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Fibonacci_When1_ShouldReturn1()
        {
            FibonacciCalculator Calculator = new FibonacciCalculator();
            Assert.AreEqual(1.ToString(), Calculator.CalculateValue(1));
        }

        [TestMethod]
        public void Fibonacci_When2_ShouldReturn1()
        {
            FibonacciCalculator Calculator = new FibonacciCalculator();
            Assert.AreEqual(1.ToString(), Calculator.CalculateValue(2));
        }

        [TestMethod]
        public void Fibonacci_When3_ShouldReturn2()
        {
            FibonacciCalculator Calculator = new FibonacciCalculator();
            Assert.AreEqual(2.ToString(), Calculator.CalculateValue(3));
        }

        [TestMethod]
        public void Fibonacci_When4_ShouldReturn3()
        {
            FibonacciCalculator Calculator = new FibonacciCalculator();
            Assert.AreEqual(3.ToString(), Calculator.CalculateValue(4));
        }

        [TestMethod]
        public void Fibonacci_When5_ShouldReturn5()
        {
            FibonacciCalculator Calculator = new FibonacciCalculator();
            Assert.AreEqual(5.ToString(), Calculator.CalculateValue(5));
        }

        [TestMethod]
        public void Fibonacci_When6_ShouldReturn8()
        {
            FibonacciCalculator Calculator = new FibonacciCalculator();
            Assert.AreEqual(8.ToString(), Calculator.CalculateValue(6));
        }

        [TestMethod]
        public void Fibonacci_When20_ShouldReturn6765()
        {
            FibonacciCalculator Calculator = new FibonacciCalculator();
            Assert.AreEqual(6765.ToString(), Calculator.CalculateValue(20));
        }

        [TestMethod]
        public void Fibonacci_When100_ShouldReturn354224848179261915075()
        {
            var expected  = BigInteger.Parse("354224848179261915075");
            FibonacciCalculator Calculator = new FibonacciCalculator();
            var result = Calculator.CalculateValue(100);
            Assert.AreEqual(expected.ToString(), result);
        }

        [TestMethod]
        public void Fibonacci_WhenLessThan1_ShouldReturnAStringStatingTheRangeOfTheApplication()
        {
            FibonacciCalculator Calculator = new FibonacciCalculator();
            Assert.AreEqual("Use a value between 0 and 100", Calculator.CalculateValue(-2));
        }

        [TestMethod]
        public void Fibonacci_WhenGreatherThan100_ShouldReturnAStringStatingTheRangeOfTheApplication()
        {
            FibonacciCalculator Calculator = new FibonacciCalculator();
            Assert.AreEqual("Use a value between 0 and 100", Calculator.CalculateValue(102));
        }
    }
}
