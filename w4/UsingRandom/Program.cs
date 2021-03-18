/*
 * 示範亂數產生器的使用
 * 03/18/2021
 */

using System;

namespace UsingRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            int seed = 123;
            Random rand = new Random(seed);
            int i;
            int k;
            int[] count = new int[10];
            for (k = 0; k < 10; ++k)
            {
                count[k] = 0;
            }
            const int N = 1000;
            for (i = 0; i < N; ++i)
            {
                k = rand.Next() % 10;
                ++count[k];
            }
            for (k = 0; k < 10; ++k)
            {
                Console.WriteLine("數字{0}出現的比例: {1}",
                    k, (double)count[k] / N);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ..");
            Console.ReadKey();
        }
    }
}
