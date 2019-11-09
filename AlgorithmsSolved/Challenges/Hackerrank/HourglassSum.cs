using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class HourglassSum
    {
        //https://www.hackerrank.com/challenges/2d-array/problem        
        static int hourglassSum(int[][] arr)
        {
            int result = 0;
            int max = -63;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    result = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if (max < result)
                        max = result;
                }
            }
            return max;
        }
    }
}
