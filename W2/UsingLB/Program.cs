/*
*example for boolean variables,relational operation and logical operation
*03/04/2021
*/

using System;

namespace UsingLB
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = 7 > 3;
            bool y = 2 < 0; 
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            bool xORy = x | y;
            Console.WriteLine("x | ｙ = " + xORy);
            bool xANDy = x & y;
            Console.WriteLine("x & ｙ = " + xANDy);
            bool xOy = (x & y ) | (x | y);
            Console.WriteLine("(x & y ) | (x | y) = " + xOy);
            bool xNy = (x & y ) & (x | y);
            Console.WriteLine("(x & y ) & (x | y) = " + xNy);

            Console.ReadKey();
        }
    }
}
