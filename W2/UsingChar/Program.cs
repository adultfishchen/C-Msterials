/*
*example for using char
*03/04/2021
*/

using System;

namespace UsingChar
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1 = 'a';
            char c2 = '文';
            char c3 = '\x0059'; //16進位字元
            char c4 = '\u0058'; //unicode
            char c5 = '\'';
            char c6 = '\n'; 
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6);

            Console.ReadKey();
        }
    }
}
