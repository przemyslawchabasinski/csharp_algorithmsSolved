using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public static class MiniMaxSum
    {
        //int[] vs = new int[] { 1, 2, 3, 4, 5 };
        //MiniMaxSum2(vs);

        //Faild test cases
        public static void MiniMaxSum1(int[] args)
        {
            long sum = args.Sum();
            long max = 0;
            long min = sum;

            foreach (long item in args)
            {
                sum = args.Where(x => x != item).Sum();
                if (max < sum)
                    max = sum;

                if (min > sum)
                    min = sum;
            }

            Console.Write(string.Join(" ", min, max));
        }

        //Good
        public static void MiniMaxSum2(int[] arr)
        {
            long sum = 0;
            long sumGeneral = 0;
            long max = 0;
            long min;

            for (int i = 0; i < arr.Length; i++)
            {
                sumGeneral += arr[i];
            }

            min = sumGeneral;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sumGeneral - arr[i];

                if (max < sum)
                    max = sum;

                if (min > sum)
                    min = sum;
            }

            Console.Write(string.Join(" ", min, max));
        }
    }
}
