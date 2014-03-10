using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MattNedrich.Algorithms.Numbers;

namespace AlgorithmsTest.Numbers
{
    [TestFixture]
    public class PrimeSieveTests
    {
        PrimeSieve sieve;

        [SetUp]
        public void Setup()
        {
            sieve = new PrimeSieve();
        }

        [Test]
        [TestCase(1)]
        [TestCase(0)]
        [TestCase(-1)]
        public void Returns_Empty_Set_For_MaxVal_Less_Than_Two(int maxValue)
        {
            IEnumerable<int> primes = sieve.GeneratePrimes(maxValue);
            Assert.IsFalse(primes.Any());
        }

        [Test]
        public void Sieve_Up_To_5_Works()
        {
            List<int> primes = sieve.GeneratePrimes(5).ToList();
            List<int> expectedResult = new List<int> { 2, 3, 5 };
            Assert.That(primes.SequenceEqual<int>(expectedResult));
        }

        [Test]
        public void Sieve_Up_To_100_Works()
        {
            List<int> primes = sieve.GeneratePrimes(100).ToList();
            List<int> expectedResult = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            Assert.That(primes.SequenceEqual<int>(expectedResult));
        }
    }
}
