/*
 * 以質數數列說明一維陣列之使用
 * 03/18/2021
 */

using System;

namespace Array1D2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p = { 2, 3, 5, 7, 11 };
            int i;
            for (i = 0; i < p.Length; ++i)
            {
                Console.WriteLine(p[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
