/*
*example for data type conversion
*03/04/2021
*/

using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = 0;
            b = a; //implicit
            b = 20.5;
            a = (int)b; //explicit
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            float c  = 20;
            c = 20.5f;
            c = (float) 20.5;
            Console.WriteLine("c = " + c);
            char d = (char)65;
            Console.WriteLine("d = " + d);
            short s = (short)'\n';
            Console.WriteLine("s = " + s);

            Console.ReadKey();
        }
    }
}
