// 第三支程式
// 2021/02/24
// 製作互動式程式

using System;
using System.IO;

namespace BasicIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello," + name);

            Console.WriteLine();
            Console.WriteLine("Please press any key to finish.");
            Console.ReadLine();
            
        }
    }
}
