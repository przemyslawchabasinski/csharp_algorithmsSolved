using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class AngryProfessor
    {
        //https://www.hackerrank.com/challenges/angry-professor/problem
        static string angryProfessor(int k, int[] a)
        {
            return a.Where(x => x <= 0).Count() >= k ? "YES" : "NO";
        }
    }
}
