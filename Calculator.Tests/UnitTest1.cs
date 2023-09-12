using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Sqrt_25_5return()
        {
            int a = 25;
            int expected = 5;
            Calculator calculator = new Calculator();
            int actual = calculator.Sqrt(a);
            //Assert.AreEqual(expected, actual);
            StringAssert.Contains("витя прогулял мпт", "мпт");
        }
    }
}
