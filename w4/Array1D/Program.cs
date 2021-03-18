/*
*以質數數列說明一維陣列之使用
*03/18/2021
*/

using System;

namespace Array1D
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 5;
            int[] p = new int[N];
            p[0] = 2;
            p[1] = 3;
            p[2] = 5;
            p[3] = 7;
            p[4] = 11;
            int i;
            for (i = 0; i < N; ++i)
            {
                Console.WriteLine(p[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
