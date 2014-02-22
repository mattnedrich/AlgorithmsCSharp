using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MattNedrich.Algorithms.Clustering.KMeans.Utilities;

namespace AlgorithmsTests.Clustering
{
    [TestFixture]
    public class SumOfSquaresDistanceCalculatorTests
    {
        [Test]
        public void Distance_From_A_Point_To_Itself_Is_Zero()
        {
            double[] vectorA = new double[] { 2, 2 };
            double[] vectorB = new double[] { 2, 2 };
            double expectedAnswer = 0.0f;
            double actualAnswer = new SumOfSquaresDistanceCalculator().CalculateDistance(vectorA, vectorB);
            Assert.That(expectedAnswer == actualAnswer);
        }

        [Test]
        public void Simple_Distance_Calculation()
        {
            double[] vectorA = new double[] { 0, 0 };
            double[] vectorB = new double[] { 1, 0 };
            double expectedAnswer = 1.0f;
            double actualAnswer = new SumOfSquaresDistanceCalculator().CalculateDistance(vectorA, vectorB);
            Assert.That(expectedAnswer == actualAnswer);
        }

        [Test]
        public void Advanced_Distance_Calculation()
        {
            double[] vectorA = new double[] { -1, 2 };
            double[] vectorB = new double[] { 5, 4 };
            double expectedAnswer = 40.0f;
            double actualAnswer = new SumOfSquaresDistanceCalculator().CalculateDistance(vectorA, vectorB);
            Assert.That(expectedAnswer == actualAnswer);
        }
    }
}
