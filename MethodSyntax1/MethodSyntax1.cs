﻿using System.Collections.Generic;
using System.Linq;

namespace MethodSyntax1
{
    public static class MethodSyntax1
    {
        public static IEnumerable<string> FilterAndSort(IEnumerable<string> inValues, string pattern)
        {
            return inValues
                //// START SOLUTION ////
                .Where(_ => _.Contains(pattern))
                .OrderBy(_ => _)
                //// END SOLUTION ////
                // LINQ method calls here
                ;
        }
    }
}