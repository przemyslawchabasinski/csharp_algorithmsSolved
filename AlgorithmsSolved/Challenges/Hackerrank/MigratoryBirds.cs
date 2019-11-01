using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class MigratoryBirds
    {
        //https://www.hackerrank.com/challenges/migratory-birds/problem

        static int migratoryBirds(List<int> arr)
        {
            int result = 0;
            int[] birdsSpotted = new int[5] { 0, 0, 0, 0, 0 };
            int max = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                birdsSpotted[arr[i] - 1] += 1;
            }

            max = birdsSpotted.Max();

            for (int i = 0; i < arr.Count; i++)
            {
                if (birdsSpotted[i] == max)
                    return i + 1;
            }

            return result;
        }
    }
}
