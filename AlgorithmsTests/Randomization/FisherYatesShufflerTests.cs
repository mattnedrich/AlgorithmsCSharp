using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MattNedrich.Algorithms.Randomization;

namespace AlgorithmsTest.Randomization
{
    [TestFixture]
    public class FisherYatesShufflerTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Null_Input_To_Shuffle_Throws_ArgumentNullException()
        {
            List<int> nullList = null;
            new FisherYatesShuffler(new Random()).Shuffle(nullList);
        }
    }
}
