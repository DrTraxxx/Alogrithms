using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Tasks
{
    public static class MinMaxSum
    {
        static void miniMaxSum(int[] arr)
        {
            long[] sortedArr = new long[5];
            int temp = 0;
            long minSum = 0;
            long maxSum = 0;


            // sorting the arr if not sorted 

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = i + 1; j <= arr.Length - 1; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++) //populating sortedArr
                sortedArr[i] = arr[i];

            for (int i = 0; i < sortedArr.Length - 1; i++) // getting min sum of the for numbers of the arr
                minSum += arr[i];

            for (int i = 1; i < sortedArr.Length; i++) // getting max sum of the for numbers of the arr
                maxSum += arr[i];
            Console.WriteLine("{0} {1}", minSum, maxSum);
        }

    }
}
