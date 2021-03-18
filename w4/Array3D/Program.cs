/*
 * 示範三維陣列的使用
 * 03/21/2021
 */

using System;

namespace Array3D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[, ,] a = { { {1, 2}, {-1, 1}, {0, 5} },
                          { {2, 4}, {1, 3}, {3, 7} },
                          { {4, 0}, {8, -3}, {9, 6} },
                          { {-2, 3}, {5, -2}, {1, 1} } };
            for (int i = 0; i < a.GetUpperBound(0) + 1; ++i)
            {
                for (int j = 0; j < a.GetUpperBound(1) + 1; ++j)
                {
                    for (int k = 0; k < a.GetUpperBound(2) + 1; ++k)
                    {
                        Console.Write("a[{0}, {1}, {2}] = {3}  \t",
                            i, j, k, a[i, j, k]);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
