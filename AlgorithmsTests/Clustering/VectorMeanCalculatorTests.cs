using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MattNedrich.Algorithms.Clustering.KMeans.Utilities;

namespace AlgorithmsTest.Clustering
{
    [TestFixture]
    public class VectorMeanCalculatorTests
    {
        [Test]
        public void Empty_Vector_Lists_Returns_Empty_Mean_Vector()
        {
            double[] meanVector = new VectorMeanCalculator().CalculateMean(new List<double[]>());
            Assert.That(meanVector.Length == 0);
        }

        [Test]
        public void Mean_Of_Same_Vectors_Is_Same()
        {
            double[] vectorA = new double[] { 1 };
            double[] vectorB = new double[] { 1 };

            double[] meanVector = new VectorMeanCalculator().CalculateMean(vectorA, vectorB);
            Assert.That(meanVector.SequenceEqual<double>(new double[] { 1 }));
        }

        [Test]
        public void Test_Mean_Of_1_and_2()
        {
            double[] vectorA = new double[] { 1 };
            double[] vectorB = new double[] { 2 };

            double[] meanVector = new VectorMeanCalculator().CalculateMean(vectorA, vectorB);
            Assert.That(meanVector.SequenceEqual<double>(new double[] { 1.5f }));
        }

        [Test]
        public void Test_Two_Dimensional_Mean()
        {
            double[] vectorA = new double[] { 1, 1 };
            double[] vectorB = new double[] { 2, 6 };

            double[] meanVector = new VectorMeanCalculator().CalculateMean(vectorA, vectorB);
            Assert.That(meanVector.SequenceEqual<double>(new double[] { 1.5, 3.5 }));
        }

    }
}
