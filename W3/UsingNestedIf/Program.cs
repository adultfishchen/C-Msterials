/*
 * 以判斷成績作為使用nested if敘述的例子
 * 03/12/2021
 */

using System;

namespace UsingNestedIf
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FAIL_THRESHOLD = 60;
            const int GOOD_GRADE_THRESHOLD = 80;
            Console.Write("Please enter your grade :　");
            int grade = Convert.ToInt16(Console.ReadLine());
            if(grade < FAIL_THRESHOLD)
            {
                Console.WriteLine("Notice, you are fail!!");
            }
            else
            {
                if(grade < GOOD_GRADE_THRESHOLD)
                {
                    Console.WriteLine("Medium Performance!");
                }
                else
                {
                    Console.WriteLine("Perfact Performance!!");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();

        }
    }
}
