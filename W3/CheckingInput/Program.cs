/*
*檢查輸入資料的合理性
*03/12/2021
*/

using System;

namespace CheckingInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 0;
            Console.Write("Please enter your grade : ");
            grade = Convert.ToInt16(Console.ReadLine());
            while(grade < 0 || grade > 100)
            {
                Console.Write("Grades need to between 0 to 100, please re-enter : ");
                grade = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Your grade is : " + grade);
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
