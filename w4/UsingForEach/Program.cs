/*
 * 示範foreach敘述的使用
 * 03/18/2021
 */

using System;

namespace UsingForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] strArray = 
            {{"Demonstrating", "the", "use", "of", "foreach"},
             {"\nGood", "for", "high", "dimensional", "array"} };
            foreach (string str in strArray)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
