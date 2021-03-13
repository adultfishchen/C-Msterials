/*
 * 利用九九乘法表示範多重迴圈
 * 03/12/2021
 */
using System;

namespace MTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int i ;
            int j ;
            for(i = 1 ; i < 10 ; ++i)
            {
                for(j = 1 ; j < 10 ; ++j)
                {
                    Console.Write("{0} * {1} = {2} ", i , j ,i*j);
                }
                // 印完一組便換行
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
