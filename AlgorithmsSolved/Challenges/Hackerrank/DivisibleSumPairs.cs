using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class DivisibleSumPairs
    {
        //https://www.hackerrank.com/challenges/divisible-sum-pairs/problem

        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int resultCount = 0;
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                if (i + 1 > n - 1)
                    return resultCount;

                for (int j = i + 1; j < n; j++)
                {
                    result = ar[i] + ar[j];
                    if (result % k == 0)
                        resultCount += 1;
                }
            }

            return resultCount;
        }
    }
}
