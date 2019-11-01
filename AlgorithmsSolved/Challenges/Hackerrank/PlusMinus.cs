using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class PlusMinus
    {
        //https://www.hackerrank.com/challenges/plus-minus/problem
        static void plusMinus(int[] arr)
        {
            float positive = 0;
            float negative = 0;
            float zero = 0;

            foreach (var item in arr)
            {
                if (item > 0)
                    positive += 1;
                else if (item < 0)
                    negative += 1;
                else
                    zero += 1;
            }

            float positiveFac = (positive / arr.Count());
            float negativeFac = negative / arr.Count();
            float zeroFac = zero / arr.Count();

            Console.WriteLine(positiveFac);
            Console.WriteLine(negativeFac);
            Console.WriteLine(zeroFac);
        }
    }
}
