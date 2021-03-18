/*
 * 猜數字遊戲虛擬碼
 * 03/18/2021
 * 
 * 虛擬碼: 猜數字遊戲
 * 1   利用亂數產生一個四位數字都不同的四位數x 
 *     最高位數可以是0
 * 2   x的四個位數為xd[0]~xd[3]
 * 3   do 
 *     {
 * 3.1   使用者輸入所猜四位數y
 * 3.2   y的四個位數為yd[0]~yd[3]
 * 3.3   n = 0  // 位置正確的位數
 * 3.4   m = 0  // 正確數字的個數
 * 3.5   for(i=0; i<4; ++i)
 *       {
 * 3.5.1    for(j=0; j<4; ++j)
 *          {
 * 3.5.1.1     if( yd[i] != xd[j] ) continue
 * 3.5.1.2     ++m
 * 3.5.1.3     if( i == j ) ++n
 * 3.5.1.4     break
 *          }
 *       }
 * 3.6   輸出nAmB
 * 3.7   if( n == 4 ) 
 *       {
 * 3.7.1    輸出猜對訊息
 * 3.7.2    break
 *       }
 *     } while ( 猜測次數未達上限 )
 * 4   輸出謎底與猜測次數
 * 
 * 
 * 虛擬碼: 利用亂數產生一個四位數字都不同的四位數
 * 1   設定陣列d[0]~d[9]為'0'~'9'
 * 2   for(i=0; i<4; ++i)
 *     {
 * 2.1   do
 *       {
 * 2.1.1    產生一個0到9的亂數k
 * 2.1.2    檢查d[k]是否與先前的xd元素重複
 *       } while( d[k] 已出現過 )
 * 2.2   xd[i] = d[k]
 *     }
 *       
 */

using System;

namespace GuessingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] xd = new char[4];


            // 利用亂數產生一個四位數字都不同的四位數, 
            // 最高位數可以是0
            // x的四個位數為xd[0]~xd[3]
            char[] d = { '0', '1', '2', '3', '4',
                         '5', '6', '7', '8', '9' };
            int i;
            int j;
            int k;
            bool again;
            Random rand = new Random();
            for (i = 0; i < 4; ++i)
            {
                do
                {
                    k = rand.Next() % 10;
                    // 檢查d[k]是否已出現過
                    again = false;
                    for (j = 0; j < i; ++j)
                    {
                        if (d[k] != xd[j]) continue;
                        again = true;
                        break;
                    }
                } while (again);
                xd[i] = d[k];
            }

            /*
            // 測試用
            xd[0] = '0';
            xd[1] = '5';
            xd[2] = '6';
            xd[3] = '7';
            */


            // 使用者開始猜測
            Console.Write("輸入猜測次數上限: ");
            int maxNGuess = Convert.ToInt16(Console.ReadLine());
            int nGuess = 0;
            char[] yd = new char[4];
            int n; // 位置正確的位數
            int m; // 正確數字的個數
            do
            {
                Console.Write("猜一個四位數: ");
                yd = Console.ReadLine().ToCharArray();
                ++nGuess;
                n = 0;
                m = 0;
                for (i = 0; i < 4; ++i)
                {
                    for (j = 0; j < 4; ++j)
                    {
                        if (yd[i] != xd[j]) continue;
                        ++m;
                        if (i == j) ++n;
                        break;
                    }
                }
                Console.WriteLine("{0}A{1}B", n, m);
                if (n == 4)
                {
                    Console.WriteLine("恭喜!您猜對了");
                    break;
                }
            } while (nGuess < maxNGuess);

            // 印出謎底與猜測次數
            Console.Write("謎底: ");
            for (i = 0; i < 4; ++i)
            {
                Console.Write(xd[i]);
            }
            Console.WriteLine();
            Console.WriteLine("您共猜了{0}次", nGuess);
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
