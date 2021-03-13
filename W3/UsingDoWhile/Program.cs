/* 
 * 利用加總示範do-while敘述的應用
 * 03/12/2021
 */
using System;

namespace UsingDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            do
            {
                sum += i ;
                ++i;
            } while(i <= 100);
            Console.WriteLine("Sum of 1 ~ 100 is " + sum);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
