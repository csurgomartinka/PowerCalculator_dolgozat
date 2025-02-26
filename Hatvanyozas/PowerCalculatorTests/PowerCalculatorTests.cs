using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Hatvanyozas;

namespace HarvanyozasTest
{
    [TestClass]
    public class PowerCalculatorTests
    {
        [TestMethod]
        public void TestPositiveExponent()
        {
            var Calculator = new PowerCalculator();
            double result = Calculator.CalCulatePower(2, 3);

            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void TestZeroExponent()
        {
            var Calculator = new PowerCalculator();
            double result = Calculator.CalCulatePower(5,0);

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestNegativeExponent()
        {
            var Calculator = new PowerCalculator();
            double result = Calculator.CalCulatePower(2, -2);

            Assert.AreEqual(0.25, result);
        }
        [TestMethod]
        public void TestZeroBasePositiveExponent()
        {
            var Calculator = new PowerCalculator();
            double result = Calculator.CalCulatePower(0, 5);

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestZeroBaseZeroExponent()
        {
            var Calculator = new PowerCalculator();
            double result = Calculator.CalCulatePower(0, 0);

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestOneBaseAnyExponent()
        {
            var Calculator = new PowerCalculator();
            double result = Calculator.CalCulatePower(1, 100);

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestNegativeBaseEvenExponent()
        {
            var Calculator = new PowerCalculator();
            double result = Calculator.CalCulatePower(-3, 4);

            Assert.AreEqual(81, result);
        }
        [TestMethod]
        public void TestNegativeBaseOddExponent()
        {
            var Calculator = new PowerCalculator();
            double result = Calculator.CalCulatePower(-2, 3);

            Assert.AreEqual(-8, result);
        }
        [TestMethod]
        public void TestNegativeBaseNegativeExponent()
        {
            var Calculator = new PowerCalculator();
            double result = Calculator.CalCulatePower(-2, -2);

            Assert.AreEqual(0.25, result);
        }
    }
}
