/*
* function1 : Drink bar menu
* function2 : Pascal's triangle
* function3 : Spreading
* 03/26/2021
*/

using System;

namespace ClassPractice
{
    class Program
    {
        static void function1()
        {
            Console.WriteLine("Enter base : ");
            string Buserinput = Console.ReadLine();
            string[] Base = Buserinput.Split(' ');
            //string[] bases = Console.ReadLine().Split(" ");
            Console.WriteLine("Enter fruit : ");
            string fuserinput = Console.ReadLine();
            string[] fruit = fuserinput.Split(' ');
            //string[] fruits = Console.ReadLine().Split(" ");
            Console.WriteLine("Menu : ");
            foreach (string str1 in Base)
            {
                foreach (string str2 in fruit)
                {
                    Console.Write(str2 + str1 + "\t");
                }
                Console.WriteLine();
            }
            /*
            for(int i = 0; i < bases.Length; i++){
                for(int j = 0; j < fruits.Length; j++){
                    Console.Write("{0, -5}", fruits[j]+bases[i]);
                    // {0, -n} : 印出第0個Object, 且印出總長度為靠左5個字元
                    // 若將這部分改寫為，存入預先宣告的Menu array，再用另一個for-for loop印出。
                    // 就可以根據最大資料長度做印出的排版。例如：
                    // Menu[i, j] = "黑金剛蓮霧優酪乳";
                    // int L_max = 0; 
                    // foreach (string drink in Menu){L_max = (L_max<drink.Length)?drink.Lnegth:L_max}
                    // Console.Write("{0, -(L_max+1)}", Menu[i, j]);
                }
                Console.WriteLine();
            }
            */
        }

        static void function2()
        {
            int rows, val = 1, blank, i, j;
            Console.Write("Please input height of the Pascal's triangle : ");
            rows = int.Parse(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("Pascal's triangle");
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        val = 1;
                    else
                        val = val * (i - j + 1) / j;
                    Console.Write(val + " ");
                    sum += val;
                }
                for (blank = 1; blank <= rows - i; blank++)
                    Console.Write(" ");
                Console.WriteLine();
            }
            Console.WriteLine("Sum of all integers equals to " + sum);

            /*
            Console.Write("Please input height of the Pascal's triangle: ");
            int sum = 0, height = int.Parse(Console.ReadLine());
            int[,] Pascal_triangle = new int[height, height];
            // C# 在宣告變數的時候都會給一個初始值，例如int初始值是0
            for(int i = 0; i < height; i++){
                for(int j = 0; j <= i; j++){
                // 用兩個for-loop來控制我們想要modify的位置
                    if(j == 0) {
                        // 因為int預設是0，我們只要考慮第 0 column必為 1 ， 
                        Pascal_triangle[i, j] = 1;
                    }
                    else{
                        Pascal_triangle[i, j] = 
                        Pascal_triangle[i-1, j-1] + Pascal_triangle[i-1, j];
                        // 其他由上[i-1, j]/左上[i-1, j-1]相加，即可。
                    }
                    sum += Pascal_triangle[i, j];
                    // modify完順便將結果加入總和
                }
            }
            Console.WriteLine(sum);
            */
        }

        static void function3()
        {
            Console.WriteLine("Please input size of class seating chart:");
            string usize = Console.ReadLine();
            string[] usizes = usize.Split(' ');
            int[] size = new int[2];
            size[0] = int.Parse(usizes[0]);
            size[1] = int.Parse(usizes[1]);
            Console.WriteLine("Please input a class seating chart:");
            int[] row = new int[size[0]];
            int[] col = new int[size[1]];
            string[] seats = Console.ReadLine().Split(' ');
            string[,] result = new string[size[0], size[1]];
            int index = 0, count = 0;
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    result[i, j] = seats[index];
                    index++;
                    if (result[i, j] == "0")
                    {
                        count++;
                    }

                }
            }
            int min = count / 3;
            if (min == 0)
            {
                min = 10;
            }
            else
            {
                min *= 10;
            }
            Console.WriteLine("{0} minutes.", min);

            /*
                 Console.WriteLine("Please input size of class seating chart:");
                string[] input = Console.ReadLine().Split(" ");
                // 將 input 分為 {number of row, number of column} 的字串陣列
                int rows = int.Parse(input[0]), cols = int.Parse(input[1]);
                bool[,] seating_chart = new bool[rows + 2, cols + 2];
                // 宣告座位表， 此處的 +2 可以讓我們懶的寫邊界判斷
                // In bool array, default is false
                // 將false作為沒被感染
                // 將true 作為已被感染
                Console.WriteLine("Please input a class seating chart:");
                for(int row = 1; row <= rows; row++){
                    string[] students = Console.ReadLine().Split(" ");
                    for(int col = 1; col <= cols; col++){
                        if (students[col - 1] == "1"){
                            seating_chart[row, col] = true;
                            // 把 "1" 的學生登記為被感染(true)
                        }
                    }
                }
                for(int t = 0; true; t+=10){
                    bool all_Infected = true;
                    for(int row = 1; row <= rows; row++){
                        for(int col = 1; col <= cols; col++){
                            all_Infected &= seating_chart[row, col];
                            // 檢查是否全部學生被感染，只要有一個學生是未感染(false)，all_Infected就會變成false
                            // 由於此處邊界設為全false，判斷要選擇中間的範圍。
                            // 若你的座位表陣列與rows, cols等大小，可以直接用foreach()
                        }
                    }
                    if (all_Infected){
                        // 若全部都被感染，印出時間 & 跳出迴圈
                        Console.WriteLine("{0} minute{1}", t, (t==0)? "":"s");
                        break;
                    }
                    var chart_copy = (bool[,]) seating_chart.Clone();
                    // 先複製一份當下的座位表，若你直接用原本的座位表進行感染，會有logical error
                    // 下面將由原本的座位表為依據，來改 10mins後的座位表
                    for(int row = 1; row <= rows; row++){
                        for(int col = 1; col <= cols; col++){
                            // 找到還沒被感染的學生(false)
                            if(!chart_copy[row, col]){
                                // 若四周有學生已被感染(true)那這名學生就會被感染(true)
                                chart_copy[row, col] = 
                                seating_chart[row - 1, col] ||
                                seating_chart[row + 1, col] ||
                                seating_chart[row, col - 1] ||
                                seating_chart[row, col + 1];
                            }
                        }
                    }// End of dealing with spreading
                    seating_chart = chart_copy; // 更新感染的狀況
                }// End of time counter (for-loop)
                */

        }

        static void Main(string[] args)
        {
            function1();
            Console.WriteLine();
            function2();
            Console.WriteLine();
            function3();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
