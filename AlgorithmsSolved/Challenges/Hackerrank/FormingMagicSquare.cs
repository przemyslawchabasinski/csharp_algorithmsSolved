using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class FormingMagicSquare
    {
        //https://www.hackerrank.com/challenges/magic-square-forming/problem
        static int formingMagicSquare(int[][] s)
        {
            int result = 0;
            int[][] allSolution = new int[][]{
                new int[]{ 8, 1, 6, 3, 5, 7, 4, 9, 2 },
                new int[]{ 6, 1, 8, 7, 5, 3, 2, 9, 4 },
                new int[]{4, 9, 2, 3, 5, 7, 8, 1, 6 },
                new int[]{2, 9, 4, 7, 5, 3, 6, 1, 8 },
                new int[]{8, 3, 4, 1, 5, 9, 6, 7, 2 },
                new int[]{4, 3, 8, 9, 5, 1, 2, 7, 6 },
                new int[]{6, 7, 2, 1, 5, 9, 8, 3, 4 },
                new int[]{2, 7, 6, 9, 5, 1, 4, 3, 8 } };
            List<int> matrixToList = new List<int>();
            List<int> sum = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixToList.Add(s[i][j]);
                }
            }

            foreach (var solution in allSolution)
            {
                for (int i = 0; i < 9; i++)
                {
                    result += Math.Abs(solution[i] - matrixToList[i]);
                }
                sum.Add(result);
                result = 0;
            }

            return sum.Min();
        }
    }
}
