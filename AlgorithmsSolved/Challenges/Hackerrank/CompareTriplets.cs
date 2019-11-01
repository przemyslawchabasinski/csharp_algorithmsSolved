using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class CompareTriplets
    {
        //https://www.hackerrank.com/challenges/compare-the-triplets/problem
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> finalScore = new List<int>() { 0, 0 };
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    finalScore[0] += 1;
                else if (a[i] < b[i])
                    finalScore[1] += 1;
            }

            return finalScore;
        }
    }
}
