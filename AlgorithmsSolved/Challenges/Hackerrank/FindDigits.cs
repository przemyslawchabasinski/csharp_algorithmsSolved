using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    class FindDigits
    {
        //https://www.hackerrank.com/challenges/find-digits/problem
        static int findDigits(int n)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int result = 0;
            string number = n.ToString();
            int divider = 0;

            for (int i = 0; i < number.Length; i++)
            {
                divider = Convert.ToInt32(Char.GetNumericValue(number[i]));
                if (divider != 0)
                {
                    if (n % divider == 0)
                        result += 1;
                }
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            return result;
        }

        static int findDigits2(int n)
        {
            Stopwatch stopwatch = new Stopwatch();
            int result = 0;
            string number = n.ToString().Replace("0", string.Empty);
            int divider = 0;

            for (int i = 0; i < number.Length; i++)
            {
                divider = Convert.ToInt32(Char.GetNumericValue(number[i]));
                if (n % divider == 0)
                    result += 1;
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            return result;
        }
    }
}
