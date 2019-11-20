using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class BigSort
    {

        //https://www.hackerrank.com/challenges/big-sorting/problem        
        static string[] bigSorting(string[] unsorted)
        {
            Array.Sort(unsorted, (left, right) => {
                if (left.Length != right.Length)
                    return left.Length - right.Length;
                return left.CompareTo(right);
            });

            return unsorted;
        }               
    }
}
