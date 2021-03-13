/*
*請設計一個程式計算國中基測分數的總分平均:
*依提示逐次輸入國文/英文/數學/自然/社會五科的成績（整數），
*最後算出總分（整數）及平均（要能夠處理小數）。
*03/04/2021
*/

using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your grade of Chinese ");
            int chi = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your grade of English ");
            int eng = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your grade of Math ");
            int math = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your grade of Society ");
            int soci = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your grade of Nature ");
            int natu = int.Parse(Console.ReadLine());

            int total = chi + eng + math + soci + natu;
            double avg = (double)total / 5;

            Console.WriteLine("Total : " + total);
            Console.WriteLine("Average : " +avg);

            // Console.ReadKey();

        }
    }
}
