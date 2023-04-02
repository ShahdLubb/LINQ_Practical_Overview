﻿using System.Collections.Generic;
using System.Linq;

namespace SingleCalculatedValue1
{
    public static class MinMax1
    {
        // Return the length of the shortest word
        public static int LengthOfShortestWord(IEnumerable<string> words)
        {
            // Uncomment:
            // return words.???();
            //// START SOLUTION ////
            return words.Min(_ => _.Length);
            //// END SOLUTION ////
        }
    }
}