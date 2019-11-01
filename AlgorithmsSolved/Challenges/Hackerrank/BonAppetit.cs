using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class BonAppetit
    {
        static void bonAppetit1(List<int> bill, int k, int b)
        {
            int sum = 0;
            int halfAnna = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                if (i != k)
                    sum += bill[i];
            }

            halfAnna = sum / 2;

            if (b == halfAnna)
                Console.WriteLine("Bon Appetit");
            else
                Console.Write(b - halfAnna);
        }

        static void bonAppetit2(List<int> bill, int k, int b)
        {
            int sum = bill.Sum();
            int halfAnna = (sum - bill[k]) / 2;

            if (b == halfAnna)
                Console.WriteLine("Bon Appetit");
            else
                Console.Write(b - halfAnna);
        }
    }
}
