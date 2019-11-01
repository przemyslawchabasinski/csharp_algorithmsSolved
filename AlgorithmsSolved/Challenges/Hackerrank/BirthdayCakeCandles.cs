using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public static class BirthdayCakeCandles
    {
        //int[] vs = new int[] { 3, 2, 1, 3 };
        //var result = BirthdayCakeCandles1(vs);
        //Console.ReadKey();

        public static int BirthdayCakeCandles1(int[] ar)
        {
            int n = ar.Length;
            int max = 0;
            int i = 0;

            foreach (int item in ar)
            {
                if (max < item)
                {
                    max = item;
                    i = 1;
                }
                else if (max == item)
                {
                    i++;
                }
            }

            return i;
        }
    }
}
