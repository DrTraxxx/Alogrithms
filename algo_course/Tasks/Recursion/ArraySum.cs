namespace Tasks
{
    public static class ArraySum
    {
        public static int Sum(int[] arr, int idx)
        {
            if (idx == arr.Length)
            {
                return arr[idx];
            };

            return arr[idx] + Sum(arr, idx + 1);
        }
    }
}