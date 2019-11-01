using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class Kangaroo
    {
        //Worst solution
        public static string Kangaroo1(int x1, int v1, int x2, int v2)
        {
            bool flag = true;
            if (x1 < x2 && v1 < v2 || x1 > x2 && v1 > v2)
                return "NO";

            if (x1 > x2)
            {
                while (flag)
                {
                    x1 += v1;
                    x2 += v2;
                    if (x1 == x2)
                        return "YES";
                    else
                        flag = x1 > x2;
                }
                return "NO";
            }
            else
            {
                while (flag)
                {
                    x1 += v1;
                    x2 += v2;
                    if (x1 == x2)
                        return "YES";
                    else
                        flag = x1 < x2;
                }
                return "NO";
            }
        }

        //Better solution
        public static string Kangaroo2(int x1, int v1, int x2, int v2)
        {
            if (x1 < x2 && v1 < v2)
                return "NO";

            while (true)
            {
                x1 += v1;
                x2 += v2;
                if (x1 == x2)
                    return "YES";
                if (x1 > x2)
                    return "NO";
            }
        }

        public static string Kangaroo3(int x1, int v1, int x2, int v2)
        {
            if (v1 < v2)
                return "NO";

            while (true)
            {
                x1 += v1;
                x2 += v2;
                if (x1 == x2)
                    return "YES";
                if (x1 > x2)
                    return "NO";
            }
        }
    }
}
