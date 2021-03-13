/*
 * 示範列舉型別之使用
 * 03/12/2021
 */

using System;

namespace UsingEnum
{
    enum WeekDay
    {
        SUN = 1,
        MON = 2,
        TUE = 3,
        WED = 4,
        THU = 5,
        FRI = 6,
        SAT = 7
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            WeekDay day = WeekDay.TUE;
            switch(day)
            {
                case WeekDay.SUN:
                    Console.WriteLine("星期日為一週的第{0}天!!", (int)WeekDay.SUN);
                    break;
                case WeekDay.MON:
                    Console.WriteLine("星期一為一週的第{0}天!!", (int)WeekDay.MON);
                    break;
                case WeekDay.TUE:
                    Console.WriteLine("星期二為一週的第{0}天!!", (int)WeekDay.TUE);
                    break;
                case WeekDay.WED:
                    Console.WriteLine("星期三為一週的第{0}天!!", (int)WeekDay.WED);
                    break;
                case WeekDay.THU:
                    Console.WriteLine("星期四為一週的第{0}天!!", (int)WeekDay.THU);
                    break;
                case WeekDay.FRI:
                    Console.WriteLine("星期五為一週的第{0}天!!", (int)WeekDay.FRI);
                    break;
                case WeekDay.SAT:
                    Console.WriteLine("星期六為一週的第{0}天!!", (int)WeekDay.SAT);
                    break;
                default:
                    Console.WriteLine("一週的第{0}天",(int)day);
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
