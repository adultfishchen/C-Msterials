/*
*Provide FIVE method to print out your basic information
*03/04/2021
*/
using System;

namespace Problem3
{
    class Program
    {
        /*first coding method : String combine Variables 

        static void Main(string[] args)
        {
            string name1 = "陳";
            string name2 = "丹妮";
            Console.WriteLine("姓名 : " + name1 + " " + name2);
        }
        */

        /*second coding method : Using number to combine String and Variables

        static void Main(string[] args)
        {
            string name1 = "陳";
            string name2 = "丹妮";
            Console.WriteLine("姓名 : {0} {1} " , name1 , name2);
            Console.ReadKey();
        }
        */

        /*third coding method : Using "Write" function !!Be aware to the difference between "Write" and "WriteLine"

        static void Main(string[] args)
        {
            string name = "陳 丹妮";
            Console.Write("姓名 : " + name + '\n'); // '\n' 代表結束本行輸出,預備輸出下一行的字元。
                                                   //另外, 程式建置時, 將此字元自動將它轉成單字元字串以符合文法要求
                                                  // 請參考3.1, 3.2節
            Console.ReadKey();
        }
        */

        /*forth coding method :　Beautify the output apperarance (Not recommend, you must apply windows program to achieve this demand)

        static void Main(string[] args)
        {
            Console.WriteLine("*_*_*_*_*_*_*_*_*_*_*_*_");
            Console.WriteLine("* 姓名: 陳丹妮         *");
            Console.WriteLine("* 學號: B10630315      *");
            Console.WriteLine("* 系級: 資管大四        *");
            Console.WriteLine("*_*_*_*_*_*_*_*_*_*_*_*_");
            Console.ReadKey();
        }
        */

        /*fifth coding method : Using "Write" function and escape sequence*/

        static void Main(string[] args)
        {
            Console.Write("*_*_*_*_*_*_*_*_*_*_*_*_\n");
            Console.Write("* 姓名: 陳丹妮\t\t*\n");
            Console.Write("* 學號: B10630315\t*\n");
            Console.Write("* 系級: 資管大四\t*\n");
            Console.Write("*_*_*_*_*_*_*_*_*_*_*_*_\n");
            Console.ReadKey();
        }
        
    }
}

