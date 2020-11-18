using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Tasks
{
    public static class PlusMinus
    {
        static void plusMinus(int[] arr)
        {
            float positives = 0, negatives = 0, zeros = 0;

            foreach (int number in arr)
            {
                //positives = (number > 0 ) ? positives++ : negatives++;

                if (number > 0)
                    positives++;

                if (number < 0)
                    negatives++;

                if (number == 0)
                    zeros++;

            }

            //var ArrLenght = arr.Length;

            positives /= arr.Length;
            negatives /= arr.Length;
            zeros /= arr.Length;

            Console.WriteLine(String.Join(Environment.NewLine, "{0}", "{1}", "{2}"), positives, negatives, zeros);
        }
    }
}
