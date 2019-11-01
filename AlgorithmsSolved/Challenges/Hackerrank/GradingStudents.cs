using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public static class GradingStudents
    {
        //https://www.hackerrank.com/challenges/grading/problem

        public static List<int> GradingStudents1(List<int> grades)
        {
            List<int> gradesFinal = new List<int>();

            foreach (var grade in grades)
            {
                if (grade >= 38)
                {
                    if ((grade + 2) % 5 == 0)
                        gradesFinal.Add(grade + 2);
                    else if ((grade + 1) % 5 == 0)
                        gradesFinal.Add(grade + 1);
                    else
                        gradesFinal.Add(grade);
                }
                else
                {
                    gradesFinal.Add(grade);
                }

            }

            return gradesFinal;
        }

        public static List<int> GradingStudents2(List<int> grades)
        {
            List<int> gradesFinal = new List<int>();
            foreach (var grade in grades)
            {
                var result = grade % 5 < 3 || grade < 38 ? grade : grade + 5 - (grade % 5);
                gradesFinal.Add(result);
            }
            return gradesFinal;
        }
    }
}
