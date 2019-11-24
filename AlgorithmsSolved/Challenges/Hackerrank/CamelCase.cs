using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    class CamelCase
    {

        //https://www.hackerrank.com/challenges/camelcase/problem
        static int camelcase(string s)
        {
            int result = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 65 && s[i] <= 90)
                    result += 1;
            }

            return result;
        }
    }
}
