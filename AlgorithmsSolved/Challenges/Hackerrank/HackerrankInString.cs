using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    class HackerrankInString
    {
        static string hackerrankInString(string s)
        {
            const string hackerrank = "hackerrank";
            string correct = "hackerrank";
            int order = 0;

            if (s.Length < hackerrank.Length)
                return "NO";

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < correct.Length; j++)
                {
                    if (s[i] == correct[j] && hackerrank[order] == s[i])
                    {
                        correct = correct.Remove(j, 1);
                        order += 1;
                        break;
                    }
                }

                if (correct == string.Empty)
                    break;
            }

            return correct == string.Empty ? "YES" : "NO";
        }
    }
}
