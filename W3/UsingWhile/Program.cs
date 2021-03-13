/* 
 * 利用累加示範使用while敘述
 * 03/12/2021
 */

using System;

namespace UsingWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            while(i <= 100)
            {
                sum +=i;
                ++i;
            }
            Console.WriteLine("Sum of 1 to 100 is " + sum);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
