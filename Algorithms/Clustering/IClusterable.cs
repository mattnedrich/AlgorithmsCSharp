using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MattNedrich.Algorithms.Clustering
{
    public interface IClusterable
    {
        double[] FeatureRepresentation { get; }
    }
}
