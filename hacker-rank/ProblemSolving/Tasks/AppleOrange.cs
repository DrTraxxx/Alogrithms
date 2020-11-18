using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Tasks
{
    public static class AppleOrange
    {
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int i = 0;
            int j = 0;
            int appleHitCount = 0;
            int orangeHitCount = 0;

            while (i <= apples.Length - 1)
            {
                var appleCoordinates = a + apples[i];

                if (appleCoordinates >= s && appleCoordinates <= t)
                    appleHitCount++;

                i++;
            }
            while (j <= oranges.Length - 1)
            {
                var orangeCoordinates = b + oranges[j];

                if (orangeCoordinates <= t && orangeCoordinates >= s)
                    orangeHitCount++;

                j++;
            }
            Console.WriteLine(appleHitCount);
            Console.WriteLine(orangeHitCount);
        }

    }
}
