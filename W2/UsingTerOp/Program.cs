/*
*Apply 調分公式 to explain the using of 三元運算子
*03/04/2021
*/

using System;

namespace UsingTerOp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個整數原始成績: ");
            int score = int.Parse(Console.ReadLine());
            // 調分公式
            int result = score < 60 ? 60 : score;
            Console.WriteLine("調分後成績: " + result);

            Console.ReadKey();
        }
    }
}
