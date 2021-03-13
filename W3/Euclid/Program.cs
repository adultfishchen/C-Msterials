/* 利用Euclid演算法找出兩數之最大公因數
 * 03/12/2021
 * 
 * Euclid演算法虛擬碼
 *  1. x = 較大的輸入值;
 *  2. y = 較小的輸入值;
 *  3. while( y不等於0)
 *     {
 *  3.1      remainder = x 除以y的餘數;
 *  3.2      x = y;
 *  3.3      y = remainder;
 *     }
 *  4. 最大公因數 = x;
 *
 * 測試
 *  1. 輸入 1, 5; 輸出 1
 *  2. 輸入 12, 18; 輸出 6
 *  3. 輸入 17, 13; 輸出 1
 */

using System;

namespace Euclid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first Integer : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second Interger : ");
            int y  = Convert.ToInt32(Console.ReadLine());

            // x較小時， x 與 y 需交換
            while(x < y)
            {
                int temp = x;
                x= y;
                y = temp;
            }            

            int remainder;

            while(y != 0)
            {
                remainder = x % y ;
                x = y;
                y = remainder;
            }

            Console.WriteLine("The GCD is {0}", x );

            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
