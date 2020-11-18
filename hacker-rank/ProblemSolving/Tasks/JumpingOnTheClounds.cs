namespace practice.Tasks
{
   public static class JumpingOnClounds
    {
       public static int jumpingOnClouds(int[] c)
        {   int jumps =0;
            int jp = 0;
            int pos = c[0] ==1 ?1:0;

            for(int i = pos;i<c.Length-1;i=i+jp)
            {
                if(i == c.Length-2)
                {
                   jp =1;
                   jumps++; 
                   break; 
                }else
                {
                    jp = c[i+2] > 0 ? 1:2;
                }
                
                jumps++;
            }

            return jumps;
        }
   }
}