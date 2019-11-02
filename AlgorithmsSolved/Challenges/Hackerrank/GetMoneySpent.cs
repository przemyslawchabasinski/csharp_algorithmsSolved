using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class GetMoneySpent
    {
        //https://www.hackerrank.com/challenges/electronics-shop/problem
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int maxPosibble = -1;
            int sumSet = 0;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    sumSet = keyboards[i] + drives[j];
                    if (sumSet <= b && maxPosibble < sumSet)
                        maxPosibble = sumSet;
                }
            }
            return maxPosibble;
        }
    }
}
