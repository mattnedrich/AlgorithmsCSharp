using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MattNedrich.Algorithms.Numbers
{
    public class PrimeSieve
    {
        public IEnumerable<int> GeneratePrimes(int maxValue)
        {
            if (maxValue < 2) // no primes below 2
                yield break;

            Dictionary<int, bool> primeMap = new Dictionary<int, bool>();
            for (int i = 0; i <= maxValue; i++)
                primeMap.Add(i, true);

            for (int candidateNumber = 2; candidateNumber <= maxValue; candidateNumber++)
            {
                if (primeMap[candidateNumber])
                {
                    yield return candidateNumber;
                    // cross off all multiples of candidate number
                    int numberToCrossOff = candidateNumber * 2;
                    while (numberToCrossOff <= maxValue)
                    {
                        primeMap[numberToCrossOff] = false;
                        numberToCrossOff += candidateNumber;
                    }
                }
            }
        }
    }
}
