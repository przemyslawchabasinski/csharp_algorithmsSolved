using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public static class TimeConversion
    {

        public static string TimeConversion1(string s)
        {
            var dt = DateTime.ParseExact(s, "h:mm:sstt", System.Globalization.CultureInfo.InvariantCulture);
            return dt.ToString("HH:mm:ss");
        }
    }
}
