using System;

namespace algocourse
{   
    using Tasks;

    class Program
    {
        static void Main(string[] args)
        { 
          var resutl = Recursion.RecursiveArraySum(new int[]{1,2,3,4,5},0);
          
          Console.WriteLine(resutl);
        }
    }
}
