using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class PickingNumber
    {
        //List<int> vs = new List<int> { 4, 6, 5, 3, 3, 1 };
        //List<int> vs = new List<int> { 1, 1, 1, 1, 1, 1 };
        //List<int> vs1 = new List<int> { 1, 2 };
        //List<int> vs1 = new List<int> { 4, 2, 3, 4, 4, 9, 98, 98, 3, 3, 3, 4, 2, 98, 1, 98, 98, 1, 1, 4, 98, 2, 98, 3, 9, 9, 3, 1, 4, 1, 98, 9, 9, 2, 9, 4, 2, 2, 9, 98, 4, 98, 1, 3, 4, 9, 1, 98, 98, 4, 2, 3, 98, 98, 1, 99, 9, 98, 98, 3, 98, 98, 4, 98, 2, 98, 4, 2, 1, 1, 9, 2, 4 };
        //List<int> vs = new List<int>() {4, 97, 5, 97, 97, 4, 97, 4, 97, 97, 97, 97, 4, 4, 5, 5, 97, 5, 97, 99, 4, 97, 5,
        //    97, 97, 97, 5, 5, 97, 4, 5, 97, 97, 5, 97, 4, 97, 5, 4, 4, 97, 5, 5, 5, 4, 97, 97,
        //    4, 97, 5, 4, 4, 97, 97, 97, 5, 5, 97, 4, 97, 97, 5, 4, 97, 97, 4, 97, 97, 97, 5, 4,
        //    4, 97, 4, 4, 97, 5, 97, 97, 97, 97, 4, 97, 5, 97, 5, 4, 97, 4, 5, 97, 97, 5, 97, 5,
        //    97, 5, 97, 97, 97 };
        //var result = pickingNumbers(vs);
        //Console.WriteLine(result);

        //https://www.hackerrank.com/challenges/picking-numbers/problem
        //Can I do it better?
        public static int pickingNumbers(List<int> a)
        {
            int result = 0;
            List<int> whichNumber = new List<int>();
            Dictionary<int, int> howMany = new Dictionary<int, int>();

            foreach (int number in a.OrderBy(x => x))
            {
                if (!howMany.ContainsKey(number))
                    howMany.Add(number, 1);
                else
                    howMany[number] += 1;
            }

            for (int i = 0; i < a.Count; i++)
            {
                foreach (var item in howMany)
                {
                    if (Math.Abs(item.Key - a[i]) == 1)
                    {
                        if (result < item.Value + howMany[a[i]])
                            result = item.Value + howMany[a[i]];
                    }

                    if (Math.Abs(item.Key - a[i]) == 0)
                    {
                        if (result < item.Value)
                            result = item.Value;
                    }

                }
            }

            if (result == 0)
                return howMany.Max().Value;
            else
                return result;
        }
    }
}
