using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class TheHurdleRace
    {
        //https://www.hackerrank.com/challenges/the-hurdle-race/problem
        static int hurdleRace(int k, int[] height)
        {
            return height.Max() - k > 0 ? height.Max() - k : 0;
        }
    }
}
