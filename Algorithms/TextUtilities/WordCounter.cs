using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MattNedrich.Algorithms.TextUtilities
{
    public class WordCounter
    {
        public int CountWords(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;
            // Assumes words are partitioned by some combination of whitespace, newlines, and carriage returns
            return input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
