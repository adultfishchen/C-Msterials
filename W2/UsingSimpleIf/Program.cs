/*
*Apply 調分公式 to explain th simple usinf of if statement
*03/04/2021
*/

using System;

namespace UsingSimpleIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個小於100的整數原始成績: ");
            int score = int.Parse(Console.ReadLine());
            //調分公式
            if (score < 60)
            {
                score = 60;
            }
            Console.WriteLine("調分後成績: " + score);

            Console.ReadKey();
        }
    }
}
