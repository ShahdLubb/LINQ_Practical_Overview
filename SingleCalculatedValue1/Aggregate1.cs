﻿using System.Collections.Generic;
using System.Linq;

namespace SingleCalculatedValue1
{
    public static class Aggregate1
    {
        // Return the total number of characters in all words in
        // the source sequence
        public static int TotalCharactersInSequence(IEnumerable<string> words)
        {
            // Uncomment:
            // return words.???();
            //// START SOLUTION ////
            return words.Aggregate(0, (a, b) => a + b.Length);
            //// END SOLUTION ////
        }
    }
}