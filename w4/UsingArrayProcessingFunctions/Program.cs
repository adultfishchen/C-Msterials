/*
 * 示範陣列的排序, 倒轉, 搜尋
 * 03/18/2021
 */



using System;

namespace UsingArrayProcessingFunctions
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
            Console.Write("原陣列a:");
            for (k = 0; k < N; ++k)
            {
                Console.Write(" {0}", a[k]);
            }
            Console.WriteLine();

            // 排序
            Array.Sort(a);
            Console.Write("排序後陣列a:");
            for (k = 0; k < N; ++k)
            {
                Console.Write(" {0}", a[k]);
            }
            Console.WriteLine();

            // 倒排
            Array.Reverse(a);
            Console.Write("倒排後陣列a:");
            for (k = 0; k < N; ++k)
            {
                Console.Write(" {0}", a[k]);
            }
            Console.WriteLine();

            // 搜尋1與2的位置
            int idx = Array.IndexOf(a, 1);
            Console.WriteLine("First index of 1 in a is {0}", idx);
            idx = Array.IndexOf(a, 2);
            Console.WriteLine("First index of 2 in a is {0}", idx);
            idx = Array.LastIndexOf(a, 1); //最後一次出現的位置
            if (idx >= 0)
            {
                Console.WriteLine("Last index of 1 in a is {0}", idx);
            }
            else
            {
                Console.Write("1 is not in array a");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
