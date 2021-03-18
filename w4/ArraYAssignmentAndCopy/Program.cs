/*
 * 示範陣列的設值與複製
 * 03/18/2021
 */

using System;

namespace ArraYAssignmentAndCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int seed = 123;
            Random rand = new Random(seed);
            const int N = 10;
            int[] a = new int[N];
            int k;
            for (k = 0; k < N; ++k)
            {
                a[k] = rand.Next() % 10;
            }

            // 陣列直接設值的副作用:以偵錯器觀察b和a的變化
            int[] b = a;
            Array.Sort(b); //a已隨b改變

            // 陣列複製的效果:以偵錯器觀察c和a的變化
            int[] c = new int[N];
            for (k = 0; k < N; ++k)
            {
                c[k] = a[k];
            }
            Array.Reverse(c); //a不隨c倒轉

            // 陣列複製的效果:以偵錯器觀察d和a的變化
            int[] d = new int[N];
            Array.Copy(a, d, N);
            Array.Reverse(d); //a不隨d倒轉

            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
