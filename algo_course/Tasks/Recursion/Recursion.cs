using System;

namespace Tasks
{
    public static class Recursion
    {
        public static int  RecursiveArraySum(int[] arr, int idx )
        {
            if(idx == arr.Length)
            {
                 return arr[idx];
            };

            return arr[1] + RecursiveArraySum(arr , idx+1);
        }

    }

}