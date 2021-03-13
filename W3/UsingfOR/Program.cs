/* 
 * 利用累加示範使用for敘述
 * 03/12/2021
 */
using System;

namespace UsingfOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int sum = 0;
            for(i = 1 ; i <= 100 ; ++i)
            {
                sum += i;
            }
            Console.WriteLine("Sum of 1 to 100 is " + sum);
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
