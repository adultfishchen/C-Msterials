/*
 * 以成績表格示範矩形陣列的使用
 * 03/18/2021
 */

using System;

namespace Array2D2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] registerNumber = { 
                "B645330", "B645331", "B645332" };
            int[,] score = { {90, 84},
                             {88, 86},
                             {86, 92} };
            //row
            int nStudents = score.GetUpperBound(0) + 1;
            //column
            int nSubjects = score.GetUpperBound(1) + 1;
            double[] individualAverage = new double[nStudents];
            double[] subjectAverage = new double[nSubjects];
            //以row計算平均，即個人平均
            for (int i = 0; i < nStudents; i++)
            {
                int sum = 0;
                for (int j = 0; j < nSubjects; j++)
                {
                    sum += score[i, j];
                }
                individualAverage[i] = (double)sum / nSubjects;
            }

            Console.WriteLine(
                "學號\\科目\t計算機概論\t計算機程式設計\t兩科平均成績");
            for (int i = 0; i < nStudents; ++i)
            {
                Console.Write(registerNumber[i] + " \t");
                for (int j = 0; j < nSubjects; ++j)
                {
                    Console.Write(score[i, j] + " \t\t");
                }
                Console.WriteLine("{0:F2}", individualAverage[i]);
            }

            //以column計算平均，即各科班級平均
            for (int j = 0; j < nSubjects; j++)
            {
                int sum = 0;
                for (int i = 0; i < nStudents; i++)
                {
                    sum += score[i, j];
                }
                subjectAverage[j] = (double)sum / nStudents;
            }
            
            Console.Write("全班平均成績\t");
            for (int j = 0; j < nSubjects; ++j)
            {
                Console.Write("{0:F2} \t\t", subjectAverage[j]);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
