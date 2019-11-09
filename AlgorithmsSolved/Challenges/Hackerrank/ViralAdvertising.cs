using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class ViralAdvertising
    {
        //https://www.hackerrank.com/challenges/strange-advertising/problem
        static int viralAdvertising(int n)
        {
            double eachLvl = 5.0;
            double result = 2.0;
            if (n == 1)
                return 2;

            for (int i = 2; i <= n; i++)
            {
                eachLvl = Math.Floor(eachLvl / 2) * 3;
                result = result + Math.Floor(eachLvl / 2);
            }
            return (int)result;
        }
    }
}
