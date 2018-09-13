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
    }
}
