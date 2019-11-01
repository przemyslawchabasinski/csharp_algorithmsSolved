using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class AVeryBigSum
    {
        //https://www.hackerrank.com/challenges/a-very-big-sum/problem
        static long aVeryBigSum1(long[] ar)
        {
            return ar.Sum();
        }

        static long aVeryBigSum2(long[] ar)
        {
            long sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }

            return sum;
        }
    }
}
