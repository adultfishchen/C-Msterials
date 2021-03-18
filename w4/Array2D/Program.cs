/*
 * 以成績表格示範矩形陣列的使用
 * 03/18/2021
 */


using System;

namespace Array2D
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N_STUDENTS = 3;
            const int N_SUBJECTS = 2;
            string[] registerNumber = new string[N_STUDENTS];
            registerNumber[0] = "B645330";
            registerNumber[1] = "B645331";
            registerNumber[2] = "B645332";
            string[] subject = new string[N_SUBJECTS];
            subject[0] = "計算機概論";
            subject[1] = "計算機程式設計";
            int[,] score = new int[N_STUDENTS, N_SUBJECTS];
            score[0, 0] = 90;
            score[0, 1] = 84;
            score[1, 0] = 88;
            score[1, 1] = 86;
            score[2, 0] = 86;
            score[2, 1] = 92;
            double[] individualAverage = new double[N_STUDENTS];
            double[] subjectAverage = new double[N_SUBJECTS];
            //已row來計算平均，即個人平均成績
            for (int i = 0; i < N_STUDENTS; i++)
            {
                int sum = 0;
                for (int j = 0; j < N_SUBJECTS; j++)
                {
                    sum += score[i, j];
                }
                individualAverage[i] = (double)sum / N_SUBJECTS;
            }

            for (int i = 0; i < N_STUDENTS; ++i)
            {
                Console.WriteLine("{0}: 兩科平均成績 {1}",
                    registerNumber[i], individualAverage[i]);
            }

            //已row來計算平均，即該科班級平均成績
            for (int j = 0; j < N_SUBJECTS; j++)
            {
                int sum = 0;
                for (int i = 0; i < N_STUDENTS; i++)
                {
                    sum += score[i, j];
                }
                subjectAverage[j] = (double)sum / N_STUDENTS;
            }
            
            for (int j = 0; j < N_SUBJECTS; ++j)
            {
                Console.WriteLine("{0}: 全班平均成績 {1}",
                    subject[j], subjectAverage[j]);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
