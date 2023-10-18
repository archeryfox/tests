using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathix.Tests
{
    [TestClass]
    public class MathixTest
    {
        private static Mathix testMathix;
        private double a;
        private double b;
        private double c;
        private static double actual;
        static double target;
        private static double expected;
        static List<double> actualList;
        static List<double> expectedList;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            testMathix = new Mathix();
            actualList = new List<double>();
            expectedList = new List<double>();
            target = 16;
            expected = 1.6;
        }

        [TestMethod]
        public void Descriminant_DLessZero_ReturnsNoRoots()
        {
            a = 1;
            b = 2;
            c = 3;
            actualList = testMathix.Descriminant(a, b, c);
            expectedList = new List<double>();
            CollectionAssert.AreEquivalent(expectedList, actualList);
        }

        [TestMethod]
        public void Descriminant_DMoreZero_Returns2Roots()
        {
            a = 3;
            b = 0;
            c = -4;
            actualList = testMathix.Descriminant(a, b, c);
            expectedList = new List<double> { 10.39, -10.39 };
            CollectionAssert.AreEqual(expectedList, actualList);
        }

        [TestMethod]
        public void Descriminant_DAreZero_Returns1Root()
        {
            a = 0;
            b = 0;
            c = 0;
            actualList = testMathix.Descriminant(a, b, c);
            expectedList = new List<double> { 0 };
            CollectionAssert.AreEquivalent(expectedList, actualList);
        }

        [TestMethod]
        public void getProcent_10procFrom16WithDelta0dot5_ReturnsCorrectProcent()
        {
            actual = testMathix.getProcent(target, 10);
            Assert.AreEqual(expected, actual, 0.5, $"Вычисляем 10% от {target}, но получили {actual}");
        }
    }
}