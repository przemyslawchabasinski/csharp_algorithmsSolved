using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public static class TheGreatXOR
    {
        //https://www.hackerrank.com/challenges/the-great-xor/problem

        //To long for solution - 4 test case failed
        public static long TheGreatXOR1(long x)
        {
            long count = 0;
            long result;
            for (int i = 1; i < x; i++)
            {
                result = i ^ x;
                if (result > x)
                    count += 1;
            }

            return count;
        }

        //To long for solution - 4 test case failed
        public static long TheGreatXOR2(long x)
        {
            long count = 0;
            for (int i = 1; i < x; i++)
            {
                if ((i ^ x) > x)
                    count += 1;
            }
            return count;
        }

    }
}
