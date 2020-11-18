namespace practice.Tasks
{
    public static class DiagonalDifference
    {
        private static int absoluteDiagonalDiff(int[][] arr)
        {
            int row = 0;

            int diagonal1 = 0;
            int diagonal2 = 0;

            for (int col = 0; col <= arr.Length - 1; col++)
            {
                row = col;
                diagonal1 += arr[col][row];
            }

            row = 0;

            for (int col = arr.Length - 1; col >= 0; col--)
            {

                diagonal2 += arr[col][row];
                row++;

            }

            var result = diagonal1 - diagonal2;

            var isNegative = result < 0;

            if (isNegative)
            {
                result *= -1;
            }

            return result;
        }
    }
}