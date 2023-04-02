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
            return names.OrderBy(name => name.Last).ThenBy(name => name.First).ThenBy(name => name.Middle).ToList();    
            //// END SOLUTION ////
        }
    }
}