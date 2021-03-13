/*
 * 以判斷成績作為使用if-else if敘述的例子
 * 03/12/2021
 */

using System;

namespace UsingIfElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your score : ");
            int score = Convert.ToInt16(Console.ReadLine());
            char grade;
            if(score >= 90)
            {
                grade = 'A';
            }
            else if (score >= 80)
            {
                grade ='B';
            }
            else if (score >= 70)
            {
                grade ='C';
            }
            else if (score >= 60)
            {
                grade ='D';
            }
            else
            {
                grade ='F';
            }
            Console.WriteLine("Your grade is " + grade);
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
