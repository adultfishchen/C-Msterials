/*
 * 示範資料陣列排序
 * 03/18/2021
 */

using System;

namespace SortingDataArray
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N_STUDENTS = 3;
            string[] registerNumber = new string[N_STUDENTS];
            registerNumber[0] = "B645330";
            registerNumber[1] = "B645331";
            registerNumber[2] = "B645332";
            int[] score = new int[N_STUDENTS];
            score[0] = 88;
            score[1] = 92;
            score[2] = 86;
            Console.WriteLine("學號 \t 成績");
            int k;
            for (k = 0; k < N_STUDENTS; ++k)
            {
                Console.WriteLine(registerNumber[k] + "\t" + score[k]);
            }
            Console.WriteLine();
            Array.Sort(score, registerNumber);
            Array.Reverse(registerNumber);
            Array.Reverse(score);
            Console.WriteLine("名次 \t 學號 \t 成績");
            for (k = 0; k < N_STUDENTS; ++k)
            {
                Console.WriteLine(
                    (k + 1) + "\t" + registerNumber[k] + "\t" + score[k]);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
