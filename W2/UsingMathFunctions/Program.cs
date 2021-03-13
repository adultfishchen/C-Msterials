/*
*example for using Math Functions
*03/04/2021
*/

using System;

namespace UsingMathFunctiona
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sqrt(2) = " + Math.Sqrt(2.0));
            Console.WriteLine("PI = " + Math.PI);
            Console.WriteLine("Sin(PI/6.0) = " + Math.Sin(Math.PI/6.0));
            Console.WriteLine("Pow(2.0,0.5) = " + Math.Pow(2.0,0.5));
            Console.WriteLine("Exp(1) = " + Math.Exp(1.0));
            Console.WriteLine("ln(e) = " + Math.Log(Math.E));
            Console.WriteLine("log10(100) = " + Math.Log10(100.0));

            Console.ReadKey();
        }
    }
}
