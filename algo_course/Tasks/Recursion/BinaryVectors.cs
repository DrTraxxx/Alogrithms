namespace Tasks
{
    using System;

    public static class BinariVector
    {
        //Generate all binary permutaitons of a given n-bit binary vector
        public static void GenerateAll(int[] arr ,int idx)
        {   
            if(idx == arr.Length)
            {
                Console.WriteLine(string.Join("",arr));
                return;
            }

            for(int i= 0 ;i<=1 ;i++)
            {
                arr[idx] = i;
                GenerateAll(arr , idx+1);
            }
        }
    }
}