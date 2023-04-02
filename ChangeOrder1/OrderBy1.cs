﻿using System.Collections.Generic;
using System.Linq;

//// START SOLUTION ////
// ReSharper disable once CheckNamespace
//// END SOLUTION ////
namespace ChangeOrder1
{
    public interface Name
    {
        //// START SOLUTION ////
        // ReSharper disable UnusedMemberInSuper.Global
        //// END SOLUTION ////
        string First { get; }
        string Middle { get; }
        //// START SOLUTION ////
        // ReSharper restore UnusedMemberInSuper.Global
        //// END SOLUTION ////
        string Last { get; }
    }

    public static class OrderBy1
    {
        // Return the provided list of names, ordered by Last, in
        // descending order.
        public static IEnumerable<Name> SortNames(IEnumerable<Name> names)
        {
            // Uncomment:
            // return names.???();
            //// START SOLUTION ////
            return names.OrderByDescending(_ => _.Last);
            //// END SOLUTION ////
        }
    }
}