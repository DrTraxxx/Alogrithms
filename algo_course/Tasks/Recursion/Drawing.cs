namespace Tasks
{
    using System;
    
    public static class Drawing
    {
         public static void Draw(int n )
        {
            if(n == 0)
            {
               return;
            }
            
            Console.WriteLine(new string ('*',n));

            Draw(n-1);

            Console.WriteLine(new string('#',n));

        }

    }

}