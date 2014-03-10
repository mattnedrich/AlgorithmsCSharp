using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MattNedrich.Algorithms.Clustering.KMeans.Utilities;

namespace AlgorithmsTest.Clustering
{
    [TestFixture]
    public class SumOfSquaresDistanceCalculatorTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Null_VectorA_Results_In_ArgumentNullException()
        {
            double[] vectorA = null;
            double[] vectorB = new double[] { 1 };
            double result = new SumOfSquaresDistanceCalculator().CalculateDistance(vectorA, vectorB);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Null_VectorB_Results_In_ArgumentNullException()
        {
            double[] vectorA = new double[] { 1 };
            double[] vectorB = null;
            double result = new SumOfSquaresDistanceCalculator().CalculateDistance(vectorA, vectorB);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Different_Size_Vectors_Results_In_ArgumentException()
        {
            double[] vectorA = new double[] { 1 };
            double[] vectorB = new double[0];
            double result = new SumOfSquaresDistanceCalculator().CalculateDistance(vectorA, vectorB);
        }

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
