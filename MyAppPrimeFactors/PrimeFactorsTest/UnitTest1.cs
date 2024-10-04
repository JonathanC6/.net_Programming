using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PrimeFactorsLibrary;

namespace PrimeFactorsTest
{
    [TestClass]
    public class PrimeFactorCalculatorTests
    {
        private PrimeFactorsCalculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new PrimeFactorsCalculator();
        }

        [TestMethod]
        public void TestPrimeFactors_Of30_ReturnsCorrectFactors()
        {
            var result = calculator.PrimeFactors(30);
            Assert.AreEqual("2 × 3 × 5", result);
        }

        [TestMethod]
        public void TestPrimeFactors_Of268_ReturnsPrimeNumber()
        {
            var result = calculator.PrimeFactors(268);
            Assert.AreEqual("2 × 2 × 67", result);
        }

        [TestMethod]
        public void TestPrimeFactors_Of1000_ReturnsCorrectFactors()
        {
            var result = calculator.PrimeFactors(1000);
            Assert.AreEqual("2 × 2 × 2 × 5 × 5 × 5", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestPrimeFactors_OutOfRange_ThrowsException()
        {
            calculator.PrimeFactors(1);
        }
    }
}
