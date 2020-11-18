using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Tasks
{
    public static class BirthDayCakeCandels
    {
        static int birthdayCakeCandles(int[] arr)
        {
            int numОfCandles = 1;
            int curretntCandle = 0;
            int hightestCandle = 0;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                curretntCandle = arr[i];

                if (curretntCandle == hightestCandle)
                {
                    numОfCandles++;
                }

                if (curretntCandle > hightestCandle)
                {
                    hightestCandle = curretntCandle;
                }

            }


            return numОfCandles;
        }
    }
}
