using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class CatAndMouse
    {
        //https://www.hackerrank.com/challenges/cats-and-a-mouse/problem
        static string catAndMouse(int x, int y, int z)
        {
            int distanceA = Math.Abs(z - x);
            int distanceB = Math.Abs(z - y);

            if (distanceA == distanceB)
                return "Mouse C";
            else if (distanceA > distanceB)
                return "Cat B";
            else
                return "Cat A";
        }
    }
}
