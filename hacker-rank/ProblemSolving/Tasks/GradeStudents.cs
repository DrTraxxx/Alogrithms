using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Tasks
{
    public static class GradingStudents
    {
        static int[] gradingStudents(int[] grades)
        {
            int[] roundedGrades = new int[grades.Length];
            int i = 0;

            while (i <= grades.Length - 1)
            {
                var currentGrade = grades[i];

                var isDevidable = (currentGrade % 5 == 0) ? true : false;

                var closestDividable = ((currentGrade / 5) + 1) * 5;
                var roundingIndex = closestDividable - currentGrade;

                if (currentGrade >= 38 && !isDevidable)
                {
                    if (roundingIndex < 3)
                    {
                        roundedGrades[i] = closestDividable;
                    }
                    else
                    {
                        roundedGrades[i] = grades[i];
                    }
                }
                else
                {
                    roundedGrades[i] = grades[i];
                }

                i++;
            }
            return roundedGrades;
        }

    }
}
