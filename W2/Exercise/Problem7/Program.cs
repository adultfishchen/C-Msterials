/*
*Deign a simple calculator
*03/09/2021
*/
using System;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input formula:");
            string str = Console.ReadLine();
            decimal a = (int)Char.GetNumericValue(str[0]);
            decimal b = (int)Char.GetNumericValue(str[2]);
            if(str[1] == '+'){
                Console.WriteLine(a+b);
                Console.WriteLine();
                Console.WriteLine("Press any key to exit ...");
                Console.ReadLine();
            }else if(str[1]=='-'){
                Console.WriteLine(a-b);
                Console.WriteLine();
                Console.WriteLine("Press any key to exit ...");
                Console.ReadLine();
            }else if(str[1] == '*'){
                Console.WriteLine(a*b);
                Console.WriteLine();
                Console.WriteLine("Press any key to exit ...");
                Console.ReadLine();
            }else if(str[1]=='/'){
                Console.WriteLine(a/b);
                Console.WriteLine();
                Console.WriteLine("Press any key to exit ...");
                Console.ReadLine();
            }
        }
    }
}
