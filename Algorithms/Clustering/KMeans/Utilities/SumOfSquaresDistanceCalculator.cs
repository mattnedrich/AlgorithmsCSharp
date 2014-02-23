using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MattNedrich.Algorithms.Clustering.KMeans.Utilities
{
    public class SumOfSquaresDistanceCalculator
    {
        public double CalculateDistance(double[] vectorA, double[] vectorB)
        {
            if (vectorA == null || vectorB == null)
                throw new ArgumentNullException("vectorA and vectorB cannot be null");
            if (vectorA.Length != vectorB.Length)
                throw new ArgumentException("Expected vectorA.Length == vetorB.Length");
            double distance = 0;
            for (int i = 0; i < vectorA.Length; i++)
                distance += Math.Pow(vectorA[i] - vectorB[i], 2);
            return distance;
        }
    }
}
