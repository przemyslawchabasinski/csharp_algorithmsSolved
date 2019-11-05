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
            //List<int> vs = new List<int> { 4, 6, 5, 3, 3, 1 };
            //List<int> vs = new List<int> { 1, 1, 1, 1, 1, 1 };
            //List<int> vs1 = new List<int> { 1, 2 };
            List<int> vs1 = new List<int> { 4, 2, 3, 4, 4, 9, 98, 98, 3, 3, 3, 4, 2, 98, 1, 98, 98, 1, 1, 4, 98, 2, 98, 3, 9, 9, 3, 1, 4, 1, 98, 9, 9, 2, 9, 4, 2, 2, 9, 98, 4, 98, 1, 3, 4, 9, 1, 98, 98, 4, 2, 3, 98, 98, 1, 99, 9, 98, 98, 3, 98, 98, 4, 98, 2, 98, 4, 2, 1, 1, 9, 2, 4 };
            var result = pickingNumbers(vs1);
            Console.WriteLine(result);
            Console.ReadKey();
        }


        //https://www.hackerrank.com/challenges/picking-numbers/problem
        //Can I do it better?
        public static int pickingNumbers(List<int> a)
        {
            int result = 0;
            int max = 0;            
            List<int> whichNumber = new List<int>();            
            Dictionary<int, int> howMany = new Dictionary<int, int>();

            foreach (int number in a.OrderBy(x => x))
            {
                if (!howMany.ContainsKey(number))
                    howMany.Add(number, 1);
                else
                    howMany[number] += 1;
            }

            foreach (var item in howMany)
            {
                if (max < item.Value)
                    max = item.Value;
            }

            foreach (var item in howMany)
            {
                if(max == item.Value)
                {                    
                    whichNumber.Add(item.Key);
                }
            }

            foreach (var item in howMany)
            {
                for (int i = 0; i < whichNumber.Count; i++)
                {
                    if(Math.Abs(item.Key - whichNumber[i]) == 1)
                    {
                        if(result < item.Value + howMany[whichNumber[i]])
                            result = item.Value + howMany[whichNumber[i]];
                    }
                }
            }

            if (result == 0)
                return max;
            else
                return result;
        }

    }

}