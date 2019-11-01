using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class Birthday
    {
        static int birthday(List<int> s, int d, int m)
        {
            int result = 0;
            int sum = 0;

            if (s.Sum() < d)
                return 0;

            if (s.Count == 0)
                return 0;

            if (s.Count == m)
                return s.Sum() == d ? 1 : 0;

            for (int i = 0; i < s.Count; i++)
            {
                if (i + m > s.Count)
                    return result;

                for (int j = i; j < i + m; j++)
                {
                    sum += s[j];
                }

                if (sum == d)
                    result += 1;
                sum = 0;
            }

            return result;
        }
    }
}
