﻿using System.Collections.Generic;
using System.Linq;

//// START SOLUTION ////
// ReSharper disable once CheckNamespace
//// END SOLUTION ////
namespace ChangeOrder2
{
    public interface Name
    {
        string First { get; }
        string Middle { get; }
        string Last { get; }
    }

    public static class ThenBy1
    {
        // Return the provided list of names, ordered by Last, then
        // First, then Middle
        public static IEnumerable<Name> SortNames(IEnumerable<Name> names)
        {
            // Uncomment:
            // return names.???();
            //// START SOLUTION ////
            return names.OrderBy(_ => _.Last).ThenBy(_ => _.First).ThenBy(_ => _.Middle);
            //// END SOLUTION ////
        }
    }
}