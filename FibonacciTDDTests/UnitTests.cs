using FibonacciTDD.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciTDDTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Fibonacci_When1_ShouldReturn1()
        {
            FibonacciCalculator Calculator = new FibonacciCalculator();
            Assert.AreEqual(1, Calculator.CalculateValue(1));
        }

        [TestMethod]
        public void Fibonacci_When2_ShouldReturn1()
        {
            FibonacciCalculator Calculator = new FibonacciCalculator();
            Assert.AreEqual(1, Calculator.CalculateValue(2));
        }

        [TestMethod]
        public void Fibonacci_When3_ShouldReturn2()
        {
            FibonacciCalculator Calculator = new FibonacciCalculator();
            Assert.AreEqual(2, Calculator.CalculateValue(3));
        }

        [TestMethod]
        public void Fibonacci_When4_ShouldReturn3()
        {
            FibonacciCalculator Calculator = new FibonacciCalculator();
            Assert.AreEqual(3, Calculator.CalculateValue(4));
        }

        [TestMethod]
        public void Fibonacci_When5_ShouldReturn5()
        {
            FibonacciCalculator Calculator = new FibonacciCalculator();
            Assert.AreEqual(5, Calculator.CalculateValue(5));
        }
    }
}
