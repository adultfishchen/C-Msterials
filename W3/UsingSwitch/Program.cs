/* 以成績等第示範switch敘述的使用
 * 03/12/2021
 */

using System;

namespace UsingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please your grade : A, B, C, D, F : ");
            char grade = Console.ReadLine().ToCharArray()[0];
            switch (grade)
            {
                case 'A':
                Console.WriteLine("Perfect performance!");
                break;
                case 'B':
                Console.WriteLine("Well performance!");
                break;
                case 'C':
                Console.WriteLine("Medium performance!");
                break;
                case 'D':
                Console.WriteLine("Not bad performance!");
                break;
                case 'F':
                Console.WriteLine("Fail!");
                break;
                default:
                Console.WriteLine("Error!");
                break;
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            
        }
    }
}