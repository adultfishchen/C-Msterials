/*
*設計一個計算三角形斜邊的程式
*03/04/2021
*/
using System;

namespace Problem4
{
    class Program
    {
        /*First Coding Mathod
        static void Main(string[] args)
        {
            Console.Write("Length of side a is: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Length of side b is: ");
            double b = double.Parse(Console.ReadLine());
            double c  = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
            Console.WriteLine("Length of side c is: {0:F4}", c); // F4 代表只顯示四位小數

            Console.ReadKey();
        }
        */

        /*Second Coding Mathod*/
        static void Main(string[] args)
        {
            Console.Write("Length of side a is: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Length of side b is: ");
            double b = double.Parse(Console.ReadLine());
            double d = a * a + b * b;
            double c  = Math.Sqrt(d);
            Console.WriteLine("Length of side c is: " + Math.Round(c , 4)); // Math.Round(x)代表取x四捨五入後之值，4代表取到小數點後第四位。

            Console.ReadKey();
        }

    }
}
