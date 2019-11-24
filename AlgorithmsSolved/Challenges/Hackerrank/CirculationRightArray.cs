using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    class CirculationRightArray
    {
        static int[] CircularArrayRotation(int[] a, int k, int[] queries)
        {
            List<int> result = new List<int>();
            int[] first, second, final;

            int n = a.Length;
            int realK = k % n;

            if (realK == 0)
            {
                for (int i = 0; i < queries.Length; i++)
                {
                    result.Add(a[queries[i]]);
                }
                return result.ToArray();
            }

            first = a.Take(n - realK).ToArray();
            second = a.Skip(n - realK).ToArray();

            final = second.Concat(first).ToArray();

            for (int i = 0; i < queries.Length; i++)
            {
                result.Add(final[queries[i]]);
            }

            return result.ToArray();
        }
    }
}
