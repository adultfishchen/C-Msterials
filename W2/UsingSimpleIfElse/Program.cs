/*
*Apply 調分公式 to explain the simple using of if-else statement
*03/04/2021
*/

using System;

namespace UsingSimpleIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個小於100的整數原始成績: ");
            int score = int.Parse(Console.ReadLine());
            // 調分公式
            int result;
            if(score < 60)
            {
                result = 60;
            } 
            else
            {
                result = score;
            }
           Console.WriteLine("調分後成績: " + result);

           Console.ReadKey(); 
        }
    }
}
