using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class SockMerchant
    {
        //https://www.hackerrank.com/challenges/sock-merchant/problem
        static int sockMerchant(int n, int[] ar)
        {
            int result = 0;
            int count = 0;
            IEnumerable<int> unique = ar.Distinct();

            foreach (var item in unique)
            {
                count = ar.Where(x => x == item).Count();
                if (count % 2 == 0)
                    result += (count / 2);
                else
                    result += ((count - 1) / 2);
            }

            return result;
        }
    }
}
