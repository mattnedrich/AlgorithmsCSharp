using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MattNedrich.Algorithms.TextUtilities
{
    public class AnagramHelper
    {
        public bool AreAnagrams(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
                return false;
            if (a.Length != b.Length)
                return false;
            // sort both string and compare each element
            string sortedA = new string(a.OrderBy(x => x).ToArray());
            string sortedB = new string(b.OrderBy(x => x).ToArray());
            for (int i = 0; i < sortedA.Length; i++)
                if (sortedA[i] != sortedB[i])
                    return false;
            return true;
        }
    }
}
