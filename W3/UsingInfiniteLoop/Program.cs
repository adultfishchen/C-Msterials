/*
 * 利用無窮迴圈檢查輸入資料的合理性
 * 03/12/2021
 */

using System;

namespace UsingInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 0;
            Console.Write("Please enter your grade : ");
            for(;;)
            {
                grade = Convert.ToInt16(Console.ReadLine());
                if(grade >= 0 && grade <= 100) break;
                // 數值合理則跳出無窮迴圈

                Console.Write("Grade needs to between 0 to 100, please re-enter : ");
    
            }
            Console.WriteLine("Your grade is " + grade);
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
