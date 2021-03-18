/*
 * 產生複利本利和計算表
 * 03/18/2021
 */

using System;

namespace Array1D3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入本金: ");
            double c = Double.Parse(Console.ReadLine());
            Console.Write("輸入利率: ");
            double p = Double.Parse(Console.ReadLine());
            Console.Write("輸入年數: ");
            int n = Int32.Parse(Console.ReadLine());
            double[] m = new double[n];
            int i;
            for (i = 0; i < n; ++i)
            {
                m[i] = c * Math.Pow(1.0 + p, i + 1);
            }
            for (i = 0; i < n; ++i)
            {
                Console.WriteLine("第{0}年後的本利和為{1}", i + 1, m[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
