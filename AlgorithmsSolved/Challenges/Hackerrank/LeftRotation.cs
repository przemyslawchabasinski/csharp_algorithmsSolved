using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class LeftRotation
    {
        //https://www.hackerrank.com/challenges/array-left-rotation/problem
        //Code didn't execute within the time limits
        static void leftRotation1(int n, int d, int[] arr)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int temp = 0;
            int realRotation = 0;
            if (d == n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(string.Format("{0} ", arr[i]));
                }
            }
            else
            {
                if (d > n)
                    realRotation = n % d;
                else
                    realRotation = d;

                for (int i = 0; i < realRotation; i++)
                {
                    temp = arr[0];
                    for (int j = 1; j < n; j++)
                    {
                        arr[j - 1] = arr[j];
                    }
                    arr[n - 1] = temp;
                }

                for (int i = 0; i < n; i++)
                {
                    Console.Write(string.Format("{0} ", arr[i]));
                }
            }

            sw.Stop();
            Console.WriteLine("Time = {0}", sw.Elapsed);
        }

        //Using temp array
        static void LeftRotation2(int n, int d, int[] arr)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] temp = new int[d];
            List<int> vs = new List<int>();
            for (int i = 0; i < d; i++)
            {
                temp[i] = arr[i];
            }

            for (int i = d; i < n; i++)
            {
                vs.Add(arr[i]);
            }

            vs.AddRange(temp);

            for (int i = 0; i < n; i++)
            {
                Console.Write(string.Format("{0} ", vs[i]));
            }
            Console.WriteLine();
            sw.Stop();
            Console.WriteLine("Time = {0}", sw.Elapsed);
        }

        //Rotate by one 
        static void LeftRotation3(int n, int d, int[] arr)
        {
            for (int i = 0; i < d; i++)
            {
                int j, temp = arr[0];
                for (j = 0; j < n - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[j] = temp;
                j = 0;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(string.Format("{0} ", arr[i]));
            }
        }
    }
}
