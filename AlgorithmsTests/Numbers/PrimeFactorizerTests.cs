using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MattNedrich.Algorithms.Numbers;

namespace AlgorithmsTest.Numbers
{
    [TestFixture]
    public class PrimeFactorizerTests
    {
        private PrimeFactorizer factorizer;

        [SetUp]
        public void Setup()
        {
            factorizer = new PrimeFactorizer();
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void Returns_Empty_Set_For_Input_Less_Than_Two(int input)
        {
            IEnumerable<int> result = factorizer.GetPrimeFactors(input);
            Assert.False(result.Any());
        }

        [Test]
        public void Works_For_Prime_Number_5()
        {
            List<int> result = factorizer.GetPrimeFactors(5).ToList();
            List<int> expectedResult = new List<int> { 5 };
            Assert.That(result.SequenceEqual<int>(expectedResult));
        }

        [Test]
        public void Works_For_Prime_Number_97()
        {
            List<int> result = factorizer.GetPrimeFactors(97).ToList();
            List<int> expectedResult = new List<int> { 97 };
            Assert.That(result.SequenceEqual<int>(expectedResult));
        }

        [Test]
        public void Works_For_Input_Of_12()
        {
            List<int> result = factorizer.GetPrimeFactors(12).ToList();
            List<int> expectedResult = new List<int> { 2, 2, 3 };
            Assert.That(result.SequenceEqual<int>(expectedResult));
        }

        [Test]
        public void Works_For_Input_Of_100()
        {
            List<int> result = factorizer.GetPrimeFactors(100).ToList();
            List<int> expectedResult = new List<int> { 2, 2, 5, 5 };
            Assert.That(result.SequenceEqual<int>(expectedResult));
        }

        [Test]
        public void Works_For_Input_Of_33()
        {
            List<int> result = factorizer.GetPrimeFactors(33).ToList();
            List<int> expectedResult = new List<int> { 3, 11 };
            Assert.That(result.SequenceEqual<int>(expectedResult));
        }
    }
}
