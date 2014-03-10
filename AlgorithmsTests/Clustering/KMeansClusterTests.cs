using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MattNedrich.Algorithms.Clustering;

namespace AlgorithmsTest.Clustering
{
    [TestFixture]
    public class KMeansClusterTests
    {
        [Test]
        public void Test_Center_Changed_True()
        {
            KMeansCluster cluster = new KMeansCluster(new double[] { 0, 0 });
            cluster.UpdateCenter(new double[] { 1, 1 });
            Assert.That(cluster.CenterChanged());
        }

        [Test]
        public void Test_Center_Changed_False()
        {
            KMeansCluster cluster = new KMeansCluster(new double[] { 0, 0 });
            cluster.UpdateCenter(new double[] { 0, 0 });
            Assert.False(cluster.CenterChanged());
        }
    }
}
