using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class MinimumNumber
    {
        //33 ! GOOD
        //35 # GOOD
        //36 $ GOOD
        //37 % GOOD
        //38 & GOOD
        //40 (
        //41 )
        //42 *
        //43 +
        //45 -
        //94 ^
        //96 @
        //https://www.hackerrank.com/challenges/strong-password/problem
        static int minimumNumber(int n, string password)
        {
            int result = 4;
            int min = 0;
            bool isLower = false;
            bool isUpper = false;
            bool isDigit = false;
            bool isSpecial = false;

            if (n < 6)
                min = (6 - n);

            for (int i = 0; i < n; i++)
            {
                if (!isLower && password[i] >= 97 && password[i] <= 122)
                {
                    result -= 1;
                    isLower = true;
                }

                if (!isUpper && password[i] >= 65 && password[i] <= 90)
                {
                    result -= 1;
                    isUpper = true;
                }

                if (!isDigit && password[i] >= 48 && password[i] <= 57)
                {
                    result -= 1;
                    isDigit = true;
                }

                if (!isSpecial &&
                    (password[i] == 33 ||
                    (password[i] >= 35 && password[i] <= 38) ||
                    (password[i] >= 40 && password[i] <= 43) ||
                    password[i] == 45 ||
                    password[i] == 94 ||
                    password[i] == 96
                    ))
                {
                    result -= 1;
                    isSpecial = true;
                }


                if (isLower && isUpper && isDigit && isSpecial)
                    break;
            }

            return result > min ? result : min;
        }
    }
}
