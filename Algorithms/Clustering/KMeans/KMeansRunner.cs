using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MattNedrich.Algorithms.Randomization;

namespace MattNedrich.Algorithms.Clustering
{
    public class KMeansRunner<T> where T : IClusterable
    {
        public IEnumerable<ClusteringResult<T>> Cluster(IList<T> observations, int numClusters)
        {
            List<KMeansCluster> clusters = ChooseInitialCentroids(observations, numClusters).ToList();

            throw new NotImplementedException("Not Implemented");
        }

        private IEnumerable<KMeansCluster> ChooseInitialCentroids(IList<T> observations, int numCentroids)
        {
            FisherYatesShuffler shuffler = new FisherYatesShuffler(new Random());
            shuffler.Shuffle(observations);
            for (int i = 0; i < numCentroids; i++)
                yield return new KMeansCluster(observations[i].FeatureRepresentation);
        }
    }

    
}
