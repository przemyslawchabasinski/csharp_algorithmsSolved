using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace AlgorithmsSolved
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = utopianTree(5);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        //https://www.hackerrank.com/challenges/utopian-tree/problem
        static int utopianTree(int n)
        {
            int result = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                    result = 1;
                else if (i % 2 == 0)
                    result += 1;
                else
                    result = result * 2;
            }

            return result;
        }
    }

}