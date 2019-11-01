using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public static class Staircase
    {
        //Staircase
        //Hackerrank
        //https://www.hackerrank.com/challenges/staircase/problem

        public static void RunStairCase()
        {
            int n = -1;
            Staircase1(n);
            Staircase2(n);

            Console.ReadKey();
        }

        public static void Staircase1(int n)
        {
            int x = 1;
            string outputHash = string.Empty;
            string outputSpace = string.Empty;
            string output = string.Empty;

            while (n > 0)
            {
                outputHash = new String('#', x);
                outputSpace = new String(' ', n - 1);
                output = string.Join("", outputSpace, outputHash);
                Console.WriteLine(output);
                x++;
                n--;
            }
        }

        //Faster than while loop
        public static void Staircase2(int n)
        {            
            if (n < 0)
                return;

            string outputHash = string.Empty;
            string outputSpace = string.Empty;
            string output = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                outputHash = new String('#', i);
                outputSpace = new String(' ', n - i);
                output = string.Join("", outputSpace, outputHash);
                Console.WriteLine(output);
            }            
        }
    }
}
