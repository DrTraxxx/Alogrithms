using System.Collections.Generic;
using System.Linq;

namespace practice.Tasks
{
    public static class CutTheSticks
    {
       public static int[] cutTheSticks(int[] arr)
        {  
           int removedCount = 0;
          List<int> allcut = new List<int>();

            while (removedCount < arr.Length)
            {
                int sticksCut = 0;
                int smallestStick = arr.Max(); // added aditional complexity :(

                for (int i = 0; i <= arr.Length - 1; i++)
                {
                    if(arr[i]>0)
                    {
                        smallestStick = arr[i]< smallestStick ? smallestStick = arr[i]: smallestStick;
                    }

                    if(i == arr.Length-1)
                    {
                        for (int j = 0; j <= arr.Length - 1; j++)
                        {
                            if (!(arr[j] == 0))
                            {
                                arr[j] = arr[j] - smallestStick;
                                sticksCut++;

                                if (arr[j] <= 0)
                                {
                                    removedCount++;
                                }
                            }
                        }
                    }
                }
                 
                 allcut.Add(sticksCut);
            }

            return allcut.ToArray();
        }
    }
}