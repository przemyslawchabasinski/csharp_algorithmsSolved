using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class DayOfProgrammer
    {
        //https://www.hackerrank.com/challenges/day-of-the-programmer/problem
        static string dayOfProgrammer(int year)
        {
            string result = "";
            bool JulianCalendar = false;
            bool leapYear = false;
            JulianCalendar = year < 1918 ? true : false;

            //From Julian to Gregorian
            if (year == 1918)
            {
                return new DateTime(year, 9, 26).ToString("dd.MM.yyyy");
            }

            if (JulianCalendar)
            {
                leapYear = year % 4 == 0 ? true : false;
            }
            else
            {
                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        leapYear = year % 400 == 0 ? true : false;
                    }
                    else
                    {
                        leapYear = true;
                    }
                }
                else
                {
                    leapYear = false;
                }

            }

            if (leapYear)
                result = new DateTime(year, 9, 12).ToString("dd.MM.yyyy");
            else
                result = new DateTime(year, 9, 13).ToString("dd.MM.yyyy");

            return result;
        }
    }
}
