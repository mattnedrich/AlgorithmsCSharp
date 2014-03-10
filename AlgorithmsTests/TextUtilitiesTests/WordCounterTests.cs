using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MattNedrich.Algorithms.TextUtilities;

namespace AlgorithmsTest.TextUtilitiesTests
{
    [TestFixture]
    public class WordCounterTests
    {
        WordCounter wordCounter;

        [SetUp]
        public void Setup()
        {
            wordCounter = new WordCounter();
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("\t")]
        [TestCase("\n")]
        [TestCase(" \t\n\r ")]
        public void Returns_Zero_For_Different_Inputs(string input)
        {
            int wordCount = wordCounter.CountWords(input);
            Assert.That(wordCount == 0);
        }

        [Test]
        [TestCase("one two")]
        [TestCase(" one two ")]
        [TestCase("one two\r\n")]
        [TestCase("one\r\ntwo\r\n")]
        [TestCase("\tone\ttwo\t")]
        public void Returns_Two_For_Various_Cases(string input)
        {
            int wordCount = wordCounter.CountWords(input);
            Assert.That(wordCount == 2);
        }

        [Test]
        [TestCase("one", 1)]
        [TestCase("one\n", 1)]
        [TestCase("\tone\r\n\r\n\n\n", 1)]
        [TestCase("one,two", 1)]
        [TestCase("one.two", 1)]
        [TestCase("one two", 2)]
        [TestCase("one\ttwo",2)]
        [TestCase("one\ntwo\nthree",3)]
        [TestCase("This is a sample sentence. This is another sample sentence.",10)]
        public void Misc_Tests(string input, int expectedResult)
        {
            int wordCount = wordCounter.CountWords(input);
            Assert.That(wordCount == expectedResult);
        }
    }
}
