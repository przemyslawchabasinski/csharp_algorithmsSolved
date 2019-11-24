using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class InsertionSort
    {
        public static int insertionSort(int[] arr)
        {
            int shifts = 0;
            for (var i = 1; i < arr.Length; i++)
            {
                int value = arr[i];
                int j = i - 1;
                while (j >= 0 && value < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    shifts += 1;
                }
                arr[j + 1] = value;
            }
            return shifts;
        }
    }
}
