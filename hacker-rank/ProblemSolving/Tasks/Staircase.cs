using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Tasks
{
    public static class Staircase
    {
        static void staircase(int n)
        {
            for (int i = n; i >= 0; i--)
            {
                int num = n;

                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");

                }

                for (int z = 0; z < num - i; z++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }

    }
}
