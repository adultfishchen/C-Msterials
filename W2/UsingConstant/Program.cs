/*
*example for using constant
*03/04/2021
*/

using System;

namespace UsingConstant
{
    class Program
    {
        static void Main(string[] args)
        {
            const double G = 9.8;
            Console.WriteLine("常數G = {0} ", G);
            double t = 1.0;
            double y = -(1.0/2.0)*G*t*t;
            /*G = 9.8 / 6;*/ //Error, constant can not be modified.
            Console.ReadKey();
        }
    }
}
