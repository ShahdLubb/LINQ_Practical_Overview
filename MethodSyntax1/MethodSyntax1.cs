﻿using System.Collections.Generic;
using System.Linq;

namespace MethodSyntax1
{
    public static class MethodSyntax1
    {
        public static IEnumerable<string> FilterAndSort(IEnumerable<string> inValues, string pattern)
        {
            return inValues
                  .Where( str => str.Contains(pattern))
                  .OrderBy(str => str)
                  .ToList();
           
        }
    }
}