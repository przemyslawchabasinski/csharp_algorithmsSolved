using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class InsertionSort2
    {
        //https://www.hackerrank.com/challenges/insertionsort2/problem
        static void insertionSort2(int n, int[] arr)
        {
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
                for (int x = 0; x < n; x++)
                {
                    Console.Write(string.Format("{0} ", arr[x]));
                }
                Console.WriteLine();
            }

        }
    }
}
