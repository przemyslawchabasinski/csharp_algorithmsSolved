using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class DiagonalDifference
    {
        //https://www.hackerrank.com/challenges/diagonal-difference/problem
        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftDiagonal = 0;
            int rightDiagonal = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == j)
                        leftDiagonal += arr[i][j];
                }
            }

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (j == arr.Count - i - 1)
                        rightDiagonal += arr[i][j];
                }
            }
            return Math.Abs(leftDiagonal - rightDiagonal);
        }
    }
}
