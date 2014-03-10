using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MattNedrich.Algorithms.TextUtilities;

namespace AlgorithmsTest.TextUtilitiesTests
{
    [TestFixture]
    public class AnagramHelperTests
    {
        private AnagramHelper anagramHelper;

        [SetUp]
        public void Setup()
        {
            anagramHelper = new AnagramHelper();
        }

        [Test]
        [TestCase("", "")]
        [TestCase("", null)]
        [TestCase(null, null)]
        public void AreAnagrams_With_Null_Or_Empty_Input_Returns_False(string a, string b)
        {
            bool result = anagramHelper.AreAnagrams(a, b);
            Assert.IsFalse(result);
        }

        [Test]
        [TestCase("test", "test")]
        [TestCase("test", "estt")]
        [TestCase("thisisalongword", "longwordaisthis")]
        [TestCase("a b c d", "c d a b")]
        public void True_Anagrams_Tests(string a, string b)
        {
            bool result = anagramHelper.AreAnagrams(a, b);
            Assert.IsTrue(result);
        }

        [Test]
        [TestCase("test", "ttst")]
        [TestCase("test", "tests")]
        [TestCase("a b", "a\tb")]
        [TestCase("one two three", "three two zero")]
        public void False_Anagrams_Tests(string a, string b)
        {
            bool result = anagramHelper.AreAnagrams(a, b);
            Assert.IsFalse(result);
        }
    }
}
