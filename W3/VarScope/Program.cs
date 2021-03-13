/*
 * 變數的生命週期範例
 * 03/12/2021
 */

using System;

namespace VarScope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a char : ");
            string s = Console.ReadLine();
            if(s == "A")
            {
                string s1 = s;
                Console.WriteLine(s1 + "is the first english character!");
            }
            else
            {
                string s1 = s;
                Console.WriteLine(s1 + "is not the first english character!");
            }

            for(int i = 0 ; i < 10 ; i++)
            {
                string s1 = s;
                Console.WriteLine(s1);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
