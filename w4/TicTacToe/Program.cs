/*
 * Tic-tac-toe遊戲虛擬碼
 * 03/18/2021
 *
 * 
 * 虛擬碼: Tic-Tac-Toe遊戲
 * 
 *    列\行  0   1   2
 *    0        |   |  
 *          ---+---+---
 *    1        |   |
 *          ---+---+---
 *    2        |   |
 *    
 * 1  board[0,0]~board[2,2]設為' '(空白)
 * 2  do
 *    {
 * 2.1   顯示棋盤
 * 2.2   使用者輸入'x'位置
 * 2.3   if( 使用者獲勝 或 board已無空格 ) break
 * 2.4   以亂數決定一個'o'位置
 * 2.5   if( 電腦獲勝 ) break
 *    } while( board仍有空格 )
 * 3  輸出棋盤及訊息
 * 
 * 
 * 虛擬碼: 判斷使用者或電腦獲勝
 * 1  設使用者或電腦最新位置在i0, j0
 * 2  檢查是否成列
 *    ( board[i0, 0] == board[i0, 1] == board[i0, 2] ) 
 * 3  檢查是否成行
 *    ( board[0, j0] == board[1, j0] == board[2, j0] )
 * 4  檢查主對角線是否均為'x' 或 'o'
 *    ( board[0, 0] == board[1, 1] == board[2, 2] == 'x' 或 'o' )
 * 5  檢查次對角線是否均為'x' 或 'o'
 *    ( board[0, 2] == board[1, 1] == board[2, 0] == 'x' 或 'o' )
 *    
 *    
 * 虛擬碼: 亂數產生'o'位置
 *     
 *        0 | 1 | 2
 *       ---+---+---
 *        3 | 4 | 5
 *       ---+---+---
 *        6 | 7 | 8
 *        
 * 1  do
 *    {
 * 1.1   產生一個0到8的亂數k
 * 1.2   io = k % 3
 * 1.3   jo = k / 3
 *    } while( board[io,jo] 不是空白 )
 *  
 * 
 */

using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = { {' ', ' ', ' '},
                              {' ', ' ', ' '},
                              {' ', ' ', ' '} };
            bool hasVacancies = true;
            bool userWin = false;
            bool computerWin = false;
            Random rand = new Random();
            do
            {
                // 顯示棋盤
                Console.Clear();
                Console.WriteLine("    0   1   2 ");
                Console.WriteLine("              ");
                Console.WriteLine("0   {0} | {1} | {2} ",
                    board[0, 0], board[0, 1], board[0, 2]);
                Console.WriteLine("   ---+---+---");
                Console.WriteLine("1   {0} | {1} | {2} ",
                    board[1, 0], board[1, 1], board[1, 2]);
                Console.WriteLine("   ---+---+---");
                Console.WriteLine("2   {0} | {1} | {2} ",
                    board[2, 0], board[2, 1], board[2, 2]);
                Console.WriteLine("              ");

                // 使用者輸入'x'位置
                Console.Write("輸入x位置的座標, 以逗點分隔: ");
                string[] input = new string[2];
                input = Console.ReadLine().Split(',');
                int ix = Convert.ToInt16(input[0]);
                int jx = Convert.ToInt16(input[1]);
                board[ix, jx] = 'x';

                // 判斷使用者是否獲勝
                userWin =
                    ((board[ix, 0] == board[ix, 1]) &&
                      (board[ix, 1] == board[ix, 2])) ||
                    ((board[0, jx] == board[1, jx]) &&
                      (board[1, jx] == board[2, jx])) ||
                    ((board[0, 0] == 'x') &&
                      (board[1, 1] == 'x') &&
                      (board[2, 2] == 'x')) ||
                    ((board[0, 2] == 'x') &&
                      (board[1, 1] == 'x') &&
                      (board[2, 0] == 'x'));

                // 檢查是否仍有空格
                hasVacancies = false;
                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        if (board[i, j] == ' ')
                        {
                            hasVacancies = true;
                            break;
                        }
                    }
                }

                if (userWin || !hasVacancies) break;

                // 以亂數決定一個'o'位置
                int io;
                int jo;
                do
                {
                    int k = rand.Next() % 9;
                    io = k % 3;
                    jo = k / 3;
                } while (board[io, jo] != ' ');
                board[io, jo] = 'o';

                // 判斷電腦是否獲勝
                computerWin =
                   ((board[io, 0] == board[io, 1]) &&
                     (board[io, 1] == board[io, 2])) ||
                   ((board[0, jo] == board[1, jo]) &&
                     (board[1, jo] == board[2, jo])) ||
                   ((board[0, 0] == 'o') &&
                     (board[1, 1] == 'o') &&
                     (board[2, 2] == 'o')) ||
                   ((board[0, 2] == 'o') &&
                     (board[1, 1] == 'o') &&
                     (board[2, 0] == 'o'));
                if (computerWin) break;

                // 檢查是否仍有空白
                hasVacancies = false;
                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        if (board[i, j] == ' ')
                        {
                            hasVacancies = true;
                            break;
                        }
                    }
                }

            } while (hasVacancies);

            // 顯示棋盤
            Console.Clear();
            Console.WriteLine("    0   1   2 ");
            Console.WriteLine("              ");
            Console.WriteLine("0   {0} | {1} | {2} ",
                board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("   ---+---+---");
            Console.WriteLine("1   {0} | {1} | {2} ",
                board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("   ---+---+---");
            Console.WriteLine("2   {0} | {1} | {2} ",
                board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("              ");

            if (userWin)
            {
                Console.WriteLine("使用者獲勝");
            }
            else if (computerWin)
            {
                Console.WriteLine("電腦獲勝");
            }
            else
            {
                Console.WriteLine("平手");
            }
            Console.WriteLine();
            Console.WriteLine("Press anykey to exit ...");
            Console.ReadKey();
        }
    }
}
