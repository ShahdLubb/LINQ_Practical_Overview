﻿using System.Collections.Generic;
using System.Linq;

namespace QuerySyntax1
{
    public static class QuerySyntax1
    {
        public static IEnumerable<string> FilterAndSort(IEnumerable<string> inValues, string pattern)
        {
            return from value in inValues
                //// START SOLUTION ////
                where value.Contains(pattern)
                orderby value
                //// END SOLUTION ////
                // LINQ instructions here
                select value;
        }
    }
}