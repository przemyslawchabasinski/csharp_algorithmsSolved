﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace AlgorithmsSolved
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.ReadKey();
        }

        //https://www.hackerrank.com/challenges/the-hurdle-race/problem
        static int hurdleRace(int k, int[] height)
        {
            return height.Max() - k > 0 ? height.Max() - k : 0;
        }

    }

}