using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MattNedrich.Algorithms.Sorting;

namespace AlgorithmsTests.Sorting
{
    [TestFixture]
    public class QuicksorterTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Sort_With_Null_Input_Throws_ArgumentException()
        {
            List<int> nullList = null;
            new Quicksorter<int>().Sort(nullList);
        }

        [Test]
        public void Empty_Input_Works()
        {
            List<int> emptyList = new List<int>();
            new Quicksorter<int>().Sort(emptyList);
        }

        [Test]
        public void Two_Element_Input_Is_Sorted_Correctly()
        {
            List<int> input = new List<int>() { 3, 1 };
            new Quicksorter<int>().Sort(input);
            Assert.That(IsSorted(input));
        }

        [Test]
        public void Three_Element_Input_Is_Sorted_Correctly()
        {
            List<int> input = new List<int>() { 3, 2, 7  };
            new Quicksorter<int>().Sort(input);
            Assert.That(IsSorted(input));
        }

        private object[] misc_test_lists = {new List<int>(){ 1, 2, 3, 4, 5 },
                                            new List<int>(){ 5, 4, 3, 2, 1 },
                                            new List<int>(){ 5, 4, 3, 2, 1, 0, -1, -2, -3, -4, -5 }};
        [Test, TestCaseSource("misc_test_lists")]
        public void Misc_Scenarios_Are_Sorted_Correctly(IList<int> input)
        {
            new Quicksorter<int>().Sort(input);
            Assert.That(IsSorted(input));
        }

        private bool IsSorted<T>(IList<T> input) where T : IComparable<T>
        {
            if (input.Count <= 1)
                return true;
            for (int i = 1; i < input.Count; i++)
                if (input[i].CompareTo(input[i - 1]) < 0)
                    return false;
            return true;
        }
    }
}
