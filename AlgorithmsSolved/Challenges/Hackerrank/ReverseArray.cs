using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class ReverseArray
    {
        static int[] reverseArray(int[] a)
        {
            int[] temp = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                temp[i] = a[a.Length - i - 1];
            }
            return temp;
        }
    }
}
