using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MattNedrich.Algorithms.Clustering.KMeans.Utilities
{
    public class VectorMeanCalculator
    {
        public double[] CalculateMean(params double[][] vectors)
        {
            return CalculateMeanCommon((IList<double[]>)vectors);   
        }

        private double[] CalculateMeanCommon(IList<double[]> vectors)
        {
            int dimensions = vectors.FirstOrDefault().Length;
            double[] total = new double[dimensions];
            for (int dimension = 0; dimension < dimensions; dimension++)
                total[dimension] += vectors.Select(x => x[dimension]).Sum();
            total = total.Select(dim => dim / vectors.Count).ToArray();
            return total;
        }
    }
}
