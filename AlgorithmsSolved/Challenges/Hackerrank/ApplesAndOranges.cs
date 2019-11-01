using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public static class ApplesAndOranges
    {
        public static void AppleAndOrange1(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int[] applesNow = new int[apples.Length];
            int[] orangesNow = new int[oranges.Length];
            int applesCount = 0;
            int orangesCount = 0;

            //Where is apple now?
            for (int i = 0; i < apples.Length; i++)
            {
                applesNow[i] = apples[i] + a;
            }

            //Where is orange now?
            for (int i = 0; i < oranges.Length; i++)
            {
                orangesNow[i] = oranges[i] + b;
            }

            for (int i = 0; i < applesNow.Length; i++)
            {
                if (s <= applesNow[i] && applesNow[i] <= t)
                    applesCount += 1;
            }

            for (int i = 0; i < orangesNow.Length; i++)
            {
                if (s <= orangesNow[i] && orangesNow[i] <= t)
                    orangesCount += 1;
            }

            Console.WriteLine(applesCount);
            Console.WriteLine(orangesCount);
        }

        public static void AppleAndOrange2(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int applesCount = 0;
            int orangesCount = 0;
            int result = 0;

            for (int i = 0; i < apples.Length; i++)
            {
                result = apples[i] + a;
                if (s <= result && result <= t)
                    applesCount += 1;
            }

            for (int i = 0; i < oranges.Length; i++)
            {
                result = oranges[i] + b;
                if (s <= result && result <= t)
                    orangesCount += 1;
            }

            Console.WriteLine(applesCount);
            Console.WriteLine(orangesCount);
        }

        public static void AppleAndOragne3(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int applesCount = 0;
            int orangesCount = 0;
            int result = 0;

            if (apples.Length == oranges.Length)
            {
                for (int i = 0; i < apples.Length; i++)
                {
                    result = apples[i] + a;
                    if (s <= result && result <= t)
                        applesCount += 1;

                    result = oranges[i] + b;
                    if (s <= result && result <= t)
                        applesCount += 1;
                }
            }
            else
            {
                for (int i = 0; i < apples.Length; i++)
                {
                    result = apples[i] + a;
                    if (s <= result && result <= t)
                        applesCount += 1;
                }

                for (int i = 0; i < oranges.Length; i++)
                {
                    result = oranges[i] + b;
                    if (s <= result && result <= t)
                        orangesCount += 1;
                }
            }
        }

        public static void AppleAndOrages4(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            Console.WriteLine(apples.Where(x => s <= (x + a) && (x + a) <= t).Count());
            Console.WriteLine(oranges.Where(x => s <= (x + b) && (x + b) <= t).Count());
        }
    }
}
