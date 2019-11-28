using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    class CaesarCipher
    {
        static string caesarCipher(string s, int k)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    result += (char)((s[i] + k - 65) % 26 + 65);
                }
                else if (Char.IsLower(s[i]))
                {
                    result += (char)((s[i] + k - 97) % 26 + 97);
                }
                else
                {
                    result += s[i];
                }
            }

            return result;
        }
    }
}
