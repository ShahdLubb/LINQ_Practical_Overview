﻿using System.Collections.Generic;
using System.Linq;

namespace CalculatedSequence1
{
    public static class Select1
    {
        public interface Name
        {
            string First { get; }
            string Middle { get; }
            string Last { get; }
        }

        // Return display strings in the form of "<Last>, <First>" for
        // each provided name
        public static IEnumerable<string> DisplayStringsForNames(IEnumerable<Name> names)
        {
            // Uncomment:
            // return names.???();
            //// START SOLUTION ////
            return names.Select(_ => $"{_.Last}, {_.First}");
            //// END SOLUTION ////
        }
    }
}