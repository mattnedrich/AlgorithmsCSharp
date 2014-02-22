using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MattNedrich.Algorithms.Clustering
{
    public class KMeansCluster
    {
        public IList<IClusterable> items { get; set; }

        public KMeansCluster(double[] center)
        {
            Center = center;
        }
        private double[] previousCenter = null;
        public double[] Center { get; set; }

        public void UpdateCenter(double[] newCenter)
        {
            previousCenter = Center;
            Center = newCenter;
        }

        public bool CenterChanged()
        {
            // must run at least one iteration
            if (previousCenter == null)
                return true;

            // if Center == prevCenter than the center hasn't changed
            for (int i = 0; i < Center.Length; i++)
                if (Center[i] != previousCenter[i])
                    return true;
            return false;
        }
    }
}
