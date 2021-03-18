/*
* Chapter 5 exercises
* function1 : Design a dynamical grade Records and calculate average and total
* function2 : Design a dynamical grade Records and calculate average, total, highest, lowest
* function3 : Design a dynamical grade Records and calculate average, total, highest, lowest, number of failed
* function4 : Design a dynamical Contacts
* function5 : Design a dynamical grade Records and calculate average, total, indiviual average, total and ranking
* function6 : Design a dynamical grade Records for semester
* function7 : Fibonacci application
* 03/18/2021
*/

using System;

namespace Exercise
{
    class Program
    {
        static void function1()
        {
            Console.WriteLine("請輸入班級人數");
            int peopleNum = int.Parse(Console.ReadLine());
            double[] score = new double[peopleNum];

            double total = 0;
            double average = 0;

            for (int i = 0; i < peopleNum; i++)
            {
                Console.WriteLine("請輸入第" + (i + 1) + "位同學的成績");
                score[i] = double.Parse(Console.ReadLine());
                total +=  score[i];
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("成績總表");
            Console.WriteLine("--------------------");
            Console.WriteLine("編號\t\t成績");
            Console.WriteLine("--------------------");

            for (int i = 0; i < peopleNum; i++)
            {
                Console.WriteLine((i + 1) + "\t\t" + score[i]);
            }
            Console.WriteLine("--------------------");

            average = total / peopleNum;

            Console.WriteLine("總分\t\t" + total);
            Console.WriteLine("平均\t\t" + average);
            Console.WriteLine("--------------------");
            Console.WriteLine();
        }

        static void function2()
        {
            Console.WriteLine("請輸入班級人數");
            int peopleNum = int.Parse(Console.ReadLine());
            double[] score = new double[peopleNum];

            double total = 0;
            double average = 0;
            double highest = 0;
            double lowest = 100;
            int fail = 0;

            for (int i = 0; i < peopleNum; i++)
            {
                Console.WriteLine("請輸入第" + (i + 1) + "位同學的成績");
                score[i] = double.Parse(Console.ReadLine());
                total += score[i];
                if (score[i] > highest)
                    highest = score[i];
                if (score[i] < lowest)
                    lowest = score[i];
                if (score[i] < 60)
                    fail++;
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("成績總表");
            Console.WriteLine("--------------------");
            Console.WriteLine("編號\t\t成績");  // \t可以水平定位
            Console.WriteLine("--------------------");

            for (int i = 0; i < peopleNum; i++)
            {
                Console.WriteLine((i + 1) + "\t\t" + score[i]);
            }
            Console.WriteLine("--------------------");

            average = total / peopleNum;

            Console.WriteLine("總分\t\t" + total);
            Console.WriteLine("平均\t\t" + average);
            Console.WriteLine("最高分\t\t" + highest);
            Console.WriteLine("最低分\t\t" + lowest);
            Console.WriteLine("被當人數\t" + fail);
            Console.WriteLine("--------------------");
        }

        static void function3()
        {
            Console.WriteLine("請輸入班級人數");
            int peopleNum = int.Parse(Console.ReadLine());
            double[] score = new double[peopleNum];

            double total = 0;
            double average = 0;
            double highest = 0;
            double lowest = 100;
            int fail = 0;

            for (int i = 0; i < peopleNum; i++)
            {
                Console.WriteLine("請輸入第" + (i + 1) + "位同學的成績");
                score[i] = double.Parse(Console.ReadLine());
                while (score[i] > 100 || score[i] < 0)
                {
                    Console.WriteLine("成績有誤，請重新輸入!");
                    score[i] = double.Parse(Console.ReadLine());
                }

                total += score[i];
                if (score[i] > highest)
                    highest = score[i];
                if (score[i] < lowest)
                    lowest = score[i];
                if (score[i] < 60)
                    fail++;
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("成績總表");
            Console.WriteLine("--------------------");
            Console.WriteLine("編號\t\t成績");  // \t可以水平定位
            Console.WriteLine("--------------------");

            for (int i = 0; i < peopleNum; i++)
            {
                Console.WriteLine((i + 1) + "\t\t" + score[i]);
            }
            Console.WriteLine("--------------------");

            average = total / peopleNum;

            Console.WriteLine("總分\t\t" + total);
            Console.WriteLine("平均\t\t" + average);
            Console.WriteLine("最高分\t\t" + highest);
            Console.WriteLine("最低分\t\t" + lowest);
            Console.WriteLine("被當人數\t" + fail);
            Console.WriteLine("--------------------");
        }

        static void function4()
        {
            Console.WriteLine("請輸入朋友數目");
            int nFriend = int.Parse(Console.ReadLine());
            string[,] data = new string[nFriend, 4];

            data[0, 0] = "姓名";
            data[0, 1] = "綽號";
            data[0, 2] = "電話";
            data[0, 3] = "信箱";

            for (int i = 0; i < nFriend; i++)
            {
                Console.WriteLine("請輸入第" + (i + 1) + "位朋友的姓名");
                data[i, 0] = Console.ReadLine();
                Console.WriteLine("請輸入第" + (i + 1) + "位朋友的綽號");
                data[i, 1] = Console.ReadLine();
                Console.WriteLine("請輸入第" + (i + 1) + "位朋友的電話");
                data[i, 2] = Console.ReadLine();
                Console.WriteLine("請輸入第" + (i + 1) + "位朋友的E-mail");
                data[i, 3] = Console.ReadLine();
            }

            Console.WriteLine("------------------");
            Console.WriteLine("朋友通訊錄");
            Console.WriteLine("------------------");

            for (int i = 0; i < nFriend; i++)
            {
                Console.WriteLine(data[i, 0] + "\t" + data[i, 1] + "\t" +
                                  data[i, 2] + "\t" + data[i, 3]);
            }
            Console.WriteLine("------------------");
        }
        
        static void function5()
        {
            Console.WriteLine("請輸入班級人數");
            int peopleNum = int.Parse(Console.ReadLine());
            double[,] score = new double[peopleNum, 3];

            for (int i = 0; i < peopleNum; i++)
            {
                Console.WriteLine("請輸入第" + (i + 1) + "位同學的國文科成績");
                score[i, 0] = double.Parse(Console.ReadLine());
                Console.WriteLine("請輸入第" + (i + 1) + "位同學的英文科成績");
                score[i, 1] = double.Parse(Console.ReadLine());
                Console.WriteLine("請輸入第" + (i + 1) + "位同學的數學科成績");
                score[i, 2] = double.Parse(Console.ReadLine());
            }


            Console.WriteLine("編號\t國文\t英文\t數學\t平均\t名次");
            Console.WriteLine("--------------------------------------------");
            double[] avg = new double[peopleNum];
            double[] avgCopy = new double[peopleNum];
            int[] seq = new int[peopleNum];

            //先計算總平均
            for (int i = 0; i < peopleNum; i++)
            {
                avg[i] = (score[i, 0] + score[i, 1] + score[i, 2]) / 3;
                avgCopy[i] = avg[i];
            }

            int idx = 0;
            //計算名次
            Array.Sort(avgCopy);
            Array.Reverse(avgCopy);
            for (int i = 0; i < peopleNum; i++)
            {
                idx = Array.IndexOf(avgCopy, avg[i]);
                seq[i] = idx + 1;
            }

            //印出個人成績和名次
            for (int i = 0; i < peopleNum; i++)
            {

                Console.Write((i + 1) + "\t" + score[i, 0]);
                Console.Write("\t" + score[i, 1]);
                Console.Write("\t" + score[i, 2]);
                Console.Write("\t" + "{0:F2}", avg[i]);
                Console.Write("\t" + seq[i] + "\n");
            }

            double chi = 0;
            double eng = 0;
            double math = 0;

            for (int j = 0; j < peopleNum; j++)
            {
                chi += score[j, 0];
                eng += score[j, 1];
                math += score[j, 2];
            }
            chi /= peopleNum;
            eng /= peopleNum;
            math /= peopleNum;

            //印出各科平均
            Console.WriteLine("--------------------------------------------");
            Console.Write("平均" + "\t" + "{0:F2}", chi);
            Console.Write("\t" + "{0:F2}", eng);
            Console.Write("\t" + "{0:F2}", math);
            Console.Write("\n");
            Console.WriteLine("--------------------------------------------");
        }

        static void function6()
        {
            Console.WriteLine("請輸入班級人數");
            int peopleNum = int.Parse(Console.ReadLine());
            int[,] score = new int[peopleNum, 3];

            for (int i = 0; i < peopleNum; i++)
            {
                Console.WriteLine("請輸入第" + (i + 1) + "位同學的期中考成績");
                score[i, 0] = int.Parse(Console.ReadLine());
                Console.WriteLine("請輸入第" + (i + 1) + "位同學的期末考成績");
                score[i, 1] = int.Parse(Console.ReadLine());
                Console.WriteLine("請輸入第" + (i + 1) + "位同學的作業成績");
                score[i, 2] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("編號\t期中考\t期末考\t作業\t總成績\t名次");
            Console.WriteLine("--------------------------------------------");
            double[] Final = new double[peopleNum];
            double[] FinalCopy = new double[peopleNum];
            int[] seq = new int[peopleNum];

            //先計算總成績
            for (int i = 0; i < peopleNum; i++)
            {
                Final[i] = score[i, 0] * 0.4 + score[i, 1] * 0.4 + 
                           score[i, 2] * 0.2;
                FinalCopy[i] = Final[i];
            }

            int idx = 0;
            //計算名次
            Array.Sort(FinalCopy);
            Array.Reverse(FinalCopy);
            for (int i = 0; i < peopleNum; i++)
            {
                idx = Array.IndexOf(FinalCopy, Final[i]);
                seq[i] = idx + 1;
            }

            //印出個人成績和名次
            for (int i = 0; i < peopleNum; i++)
            {
                Console.Write((i + 1) + "\t" + score[i, 0]);
                Console.Write("\t" + score[i, 1]);
                Console.Write("\t" + score[i, 2]);
                Console.Write("\t" + "{0:F2}", Final[i]);
                Console.Write("\t" + seq[i] + "\n");
            }

            double midexam = 0;
            double finexam = 0;
            double hw = 0;

            for (int j = 0; j < peopleNum; j++)
            {
                midexam += score[j, 0];
                finexam += score[j, 1];
                hw += score[j, 2];
            }
            midexam /= peopleNum;
            finexam /= peopleNum;
            hw /= peopleNum;

            //印出各部分平均
            Console.WriteLine("--------------------------------------------");
            Console.Write("平均" + "\t" + "{0:F2}", midexam);
            Console.Write("\t" + "{0:F2}", finexam);
            Console.Write("\t" + "{0:F2}", hw);
            Console.Write("\n");
        }

        static void function7()
        {
            int iLevel = 0;
            Console.WriteLine("Enter the Fibonacci Series Number.");
            Console.WriteLine("Program Calculate the Sum from F(0)");
            Console.WriteLine("(Entering 0 will close the program)");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");
            do
            {
                Console.WriteLine();
                Console.Write("Please Enter Your Number: ");
                iLevel = Convert.ToInt16(Console.ReadLine());
                long[] Fibonacci = new long[iLevel + 3];

                Fibonacci[0] = 0;
                Fibonacci[1] = 1;

                if (iLevel > 0)
                {
                    for (int i = 2; i <= iLevel + 2; i++)
                    {
                        Fibonacci[i] = Fibonacci[i - 1] + Fibonacci[i - 2];
                    }

                    Console.WriteLine("The Fibonacci Series, F({0}) = {1}", iLevel, Fibonacci[iLevel]);
                    Console.WriteLine("The Fibonacci Sum, F(0) to F({0}) = {1}", iLevel, Fibonacci[iLevel + 2] - 1);
                    double FibonacciRatio = Math.Round((double)Fibonacci[iLevel + 1] / Fibonacci[iLevel], 5);
                    Console.WriteLine("The Fibonacci Ratio, R = F(n+1)/F(n) = {0}", FibonacciRatio);
                }
            }
            while (iLevel > 0);
        }

        static void Main(string[] args)
        {
            function1();
            Console.WriteLine();
            function2();
            Console.WriteLine();
            function3();
            Console.WriteLine();
            function4();
            Console.WriteLine();
            function5();
            Console.WriteLine();
            function6();
            Console.WriteLine();
            function7();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
