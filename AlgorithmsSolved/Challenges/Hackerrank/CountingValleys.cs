using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class CountingValleys
    {
        //https://www.hackerrank.com/challenges/counting-valleys/problem
        static int countingValleys(int n, string s)
        {
            int result = 0;
            int startingPoint = 0;
            int oldPoint = 0;

            for (int i = 0; i < n; i++)
            {
                //Check last step before update.
                oldPoint = startingPoint;
                startingPoint = s[i] == 'U' ? startingPoint += 1 : startingPoint -= 1;

                if (oldPoint < 0 & startingPoint == 0)
                    result += 1;
            }
            return result;
        }
    }
}
