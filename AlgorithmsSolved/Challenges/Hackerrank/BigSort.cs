using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class BigSort
    {

        //https://www.hackerrank.com/challenges/big-sorting/problem        
        static string[] bigSorting(string[] unsorted)
        {
            string[] sorted = new string[unsorted.Length];
            double[] unsortedInt = new double[unsorted.Length];
            bool swapped = false;
            double temp = 0;

            //Add to mapped values from old list and new
            //I have to do it because I don't know how to return 
            //value without scientific format
            Dictionary<int, int> pairs = new Dictionary<int, int>();

            //Convert values to int
            for (int i = 0; i < unsorted.Length; i++)
            {
                unsortedInt[i] = double.Parse(unsorted[i]);
                pairs[i] = i;
            }

            //Buble sort
            do
            {
                swapped = false;
                for (int i = 0; i < unsortedInt.Length - 1; i++)
                {
                    if (unsortedInt[i] > unsortedInt[i + 1])
                    {
                        temp = unsortedInt[i + 1];
                        unsortedInt[i + 1] = unsortedInt[i];
                        unsortedInt[i] = temp;
                        pairs[i] = i + 1;
                        pairs[i + 1] = i;
                        swapped = true;
                    }
                }

            } while (swapped == true);

            //Convert values to string
            for (int i = 0; i < unsortedInt.Length; i++)
            {
                sorted[i] = unsortedInt[i].ToString();
            }

            //return
            return sorted;
        }
    }
}
