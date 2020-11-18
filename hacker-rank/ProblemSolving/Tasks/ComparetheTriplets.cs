using System.Collections.Generic;

namespace practice.Tasks
{
    public static class CompereTriplets{
         public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int aliceScore = 0;
            int bobScore = 0;

            List<int> result = new List<int>();

            for (int i = 0; i <= a.Count - 1; i++)
            {
                int r1 = a[i];
                int r2 = b[i];

                if (r1 > r2)
                    aliceScore++;

                if (r1 < r2)
                    bobScore++;

            };

            result.Add(aliceScore);
            result.Add(bobScore);

            return result;
            }
    }
}