/*
*example for basic Math Operator
*03/04/2021
*/

using System;

namespace UsingMathOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first int x : ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second int y : ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(" x + y = {0} ", x + y);
            Console.WriteLine(" x - y = {0} ", x - y);
            Console.WriteLine(" x * y = {0} ", x * y);
            Console.WriteLine(" x / y = {0} ", x / y);
            Console.WriteLine(" x % y = {0} ", x % y);

            Console.ReadKey();
        }
    }
}
