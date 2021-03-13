/*
*在請寫一個簡單的統計程式，讓使用者輸入 Lin 每場的出手次數及命中次數來計算他的得分及投籃命中率。
*03/04/2021
*/

using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入兩分球出手次數:");
            int fG2A = int.Parse(Console.ReadLine());

            Console.WriteLine("請輸入兩分球命中次數:");
            int fG2M = int.Parse(Console.ReadLine());

            Console.WriteLine("請輸入三分球出手次數:");
            int fG3A = int.Parse(Console.ReadLine());

            Console.WriteLine("請輸入三分球命中次數:");
            int fG3M = int.Parse(Console.ReadLine());

            Console.WriteLine("請輸入罰球出手次數:");
            int fTA = int.Parse(Console.ReadLine());

            Console.WriteLine("請輸入罰球命中次數:");
            int fTM = int.Parse(Console.ReadLine());

            int total = 2 * fG2M + 3 * fG3M + fTM;

            double fG2, fG3, fT;

            if(fG2A ==0 | fG2M == 0) // Avoid divide with 0 
                fG2 = 0;
            else
                fG2 = 100 * (double)fG2M / (double)fG2A;

            if(fG3A ==0 | fG3M == 0)
                fG3 = 0;
            else
                fG3 = 100 * (double)fG3M / (double)fG3A;

            if(fTA ==0 | fTM == 0)
                fT = 0;
            else
                fT = 100 * (double)fTM / (double)fTA;

            Console.WriteLine("Total : " + total);
            Console.WriteLine("兩分球命中率:" + fG2.ToString() + "%");
            Console.WriteLine("三分球命中率:" + fG3.ToString() + "%");
            Console.WriteLine("罰球命中率  :" + fT.ToString() + "%");

            Console.WriteLine();
            Console.WriteLine("Please press any key to exit ...");
            Console.ReadKey();
        }
    }
}
