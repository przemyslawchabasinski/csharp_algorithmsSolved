using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    class SuperReducedString
    {
        //https://www.hackerrank.com/challenges/reduced-string/problem
        static string superReducedString(string s)
        {
            int max = s.Length;
            bool anyAdjacent = false;

            do
            {
                anyAdjacent = false;
                for (int i = 0; i < max - 1; i++)
                {
                    if (s[i] == s[i + 1])
                    {
                        s = s.Remove(i, 2);
                        i += 1;
                        anyAdjacent = true;
                        break;
                    }
                }

                max = s.Length;

            } while (anyAdjacent);

            return s == string.Empty ? "Empty String" : s;
        }
    }
}
