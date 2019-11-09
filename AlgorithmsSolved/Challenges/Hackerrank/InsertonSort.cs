using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class InsertonSort
    {
        static void insertionSort1(int n, int[] arr)
        {
            int i, j, val, flag;
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];

                        for (int x = 0; x < arr.Length; x++)
                        {
                            Console.Write(string.Format("{0} ", arr[x]));
                        }
                        Console.WriteLine();
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            for (int x = 0; x < arr.Length; x++)
            {
                Console.Write(string.Format("{0} ", arr[x]));
            }
        }
    }
}
