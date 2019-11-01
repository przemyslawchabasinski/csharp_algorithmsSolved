using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class PageCount
    {
        //https://www.hackerrank.com/challenges/drawing-book/problem
        static int pageCount(int n, int p)
        {
            if (p == 1 || p == n)
                return 0;

            if (n % 2 == 0 && p == n - 1)
                return 1;

            //Front
            int stepFront = p % 2 == 0 ? p / 2 : (p - 1) / 2;

            //Back
            int stepBack = n % 2 != 0 && p % 2 == 0 ? (n - p - 1) / 2 : (n - p) / 2;

            return stepFront > stepBack ? stepBack : stepFront;
        }
    }
}
