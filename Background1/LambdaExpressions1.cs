﻿using System;

namespace Background1
{
    public static class LambdaExpressions1
    {
        // Write a lambda expression that will return the next number after
        // the provided integer
        //// START UNCOMMENT ////
        //public static Func<int, int> GetNextNumber = ??? => ???;
        //// END UNCOMMENT ////
        //// START SOLUTION ////
        public static Func<int, int> GetNextNumber = x => x + 1;
        //// END SOLUTION ////
    }
}