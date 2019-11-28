using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    class MarsExploration
    {
        static int marsExploration(string s)
        {
            int flag = 0;
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (flag == 0)
                {
                    if (s[i] != 'S')
                        result += 1;
                    flag = 1;
                }
                else if (flag == 1)
                {
                    if (s[i] != 'O')
                        result += 1;
                    flag = 2;
                }
                else if (flag == 2)
                {
                    if (s[i] != 'S')
                        result += 1;
                    flag = 0;
                }
            }

            return result;
        }
    }
}
