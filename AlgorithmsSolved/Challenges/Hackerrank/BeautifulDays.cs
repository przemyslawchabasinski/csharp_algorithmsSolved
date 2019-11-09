using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class BeautifulDays
    {
        //Convert to string, reverse to string and convert to integer

        //https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem
        static int beautifulDays1(int i, int j, int k)
        {
            int rev = 0;
            while (k > 0)
            {
                rev = rev * 10 + k % 10; ;
                k = k / 10;
            }

            return rev;
        }

        static int beautifulDays2(int i, int j, int k)
        {
            int rev = 0;
            int old = 0;
            int result = 0;

            for (int l = i; l <= j; l++)
            {
                old = l;
                while (old > 0)
                {
                    rev = rev * 10 + old % 10; ;
                    old = old / 10;
                }
                if ((l - rev) % k == 0)
                    result += 1;
                rev = 0;
            }
            return result;
        }
    }
}
