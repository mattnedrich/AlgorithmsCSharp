using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MattNedrich.Algorithms.Numbers
{
    public class PrimeFactorizer
    {
        public IEnumerable<int> GetPrimeFactors(int numberToFactor)
        {
            int divisor = 2;
            while (divisor <= numberToFactor)
            {
                while (numberToFactor % divisor == 0)
                {
                    yield return divisor;
                    numberToFactor = numberToFactor / divisor;
                }
                divisor++;
            }
        }
    }
}
