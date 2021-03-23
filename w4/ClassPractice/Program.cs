/*
* function1 : Number Triangle - Print a number triangle of range n, where n is a positive integer derived from user input.
* function2 : 中二 ID generator - To randomly generate a 中二 ID. Your ID may include prefix, postfix and infix. The content should be a combination of two words.
* function3 : Reverse Number - To reverse a positive number from user input. 
* 03/19/2021
*/

using System;
using System.Linq;

namespace ClassPractice
{
    class Program
    {
        static void function1()
        {
            int i, j, k, r, n;
            Console.Write("Enter the Range = ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                //數字三角形左側的空白數量為三角形高度(n)-目前第幾行(i)
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                //數字三角形左半邊為等差數列由1至i
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }

                //數字三角形右半邊為等差數列由i-1至1
                for (r = i - 1; r >= 1; r--)
                {
                    Console.Write(r);
                }
                Console.Write("\n");
            }
        }

        static void function2()
        {
            string[] output = new string[5];
            string[] pre = new string[] { "0o", "乂☆", "\\", "↗", "＊*", "卍" };
            string[] post = new string[] { "0o", "☆乂", "/", "↙", "*＊", "卍" };
            string[] infix = new string[] { "a", "o", "x", "之", "★", "～", "‧" };
            string[] fir = new string[] { "小小", "元氣", "楓糖", "霸氣", "煞氣", "闇夜", "血" };
            string[] sec = new string[] { "糖", "漾", "戀果", "鮭魚", "鮪魚", "大閘蟹" };

            //Determine what type it is
            Random rnd0 = new Random();
            int N0 = rnd0.Next(0, 4);
            //Console.WriteLine(N0);


            switch (N0)
            {
                case 0:
                    //For pre, post and sec
                    Random rnd1 = new Random();
                    int N1 = rnd1.Next(0, 5);
                    // Console.WriteLine(N1);
                    output[0] = pre[N1];
                    output[3] = sec[N1];
                    output[4] = post[N1];

                    //For infix and first
                    Random rnd2 = new Random();
                    int N2 = rnd2.Next(0, 6);
                    //Console.WriteLine(N2);
                    output[1] = fir[N2];
                    output[2] = infix[N2];

                    Console.WriteLine("Your Id is : ");
                    foreach (string str in output)
                    {
                        Console.Write("{0}", str);
                    }

                    break;

                case 1:
                    //For pre, post and sec
                    Random rnd3 = new Random();
                    int N3 = rnd3.Next(0, 5);
                    //Console.WriteLine(N3);
                    output[0] = pre[N3];
                    output[2] = sec[N3];
                    output[3] = post[N3];

                    //For first
                    Random rnd4 = new Random();
                    int N4 = rnd4.Next(0, 6);
                    //Console.WriteLine(N4);
                    output[1] = fir[N4];

                    Console.WriteLine("Your Id is : ");
                    foreach (string str in output)
                    {
                        Console.Write("{0}", str);
                    }

                    break;

                case 2:
                    //For sec
                    Random rnd5 = new Random();
                    int N5 = rnd5.Next(0, 5);
                    //Console.WriteLine(N5);
                    output[2] = sec[N5];

                    //For infix and first
                    Random rnd6 = new Random();
                    int N6 = rnd6.Next(0, 6);
                    //Console.WriteLine(N6);
                    output[0] = fir[N6];
                    output[1] = infix[N6];

                    Console.WriteLine("Your Id is : ");
                    foreach (string str in output)
                    {
                        Console.Write("{0}", str);
                    }

                    break;

                case 3:
                    //For sec
                    Random rnd7 = new Random();
                    int N7 = rnd7.Next(0, 5);
                    //Console.WriteLine(N7);
                    output[1] = pre[N7];


                    //For and first
                    Random rnd8 = new Random();
                    int N8 = rnd8.Next(0, 6);
                    //Console.WriteLine(N8);
                    output[0] = fir[N8];

                    Console.WriteLine("Your Id is : ");

                    foreach (string str in output)
                    {
                        Console.Write("{0}", str);
                    }

                    break;
            }

            //TA Example for randomly ID gereration
            /*Random rnd = new Random();
			//prefix
			int p  = rnd.Next(0, 7);
			Console.Write(prefix[p]);
			
			//first
			int f  = rnd.Next(0, 6);
			Console.Write(first[f]);
			
			//infix
			int i  = rnd.Next(0, 8);
			Console.Write(infix[i]);
			
			//second
			int s  = rnd.Next(0, 6);
			Console.Write(second[s]);
			
			//postfix
			Console.Write(postfix[p]);
			Console.Write("\n")*/;
        }

        static void function3()
        {
            int num, r, sum = 0, t;
            string output = "";

            Console.Write("\n\n");
            Console.Write("Display the number in reverse order:\n");
            Console.Write("--------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            //依序取出個位、十位...的數值
            while (num > 0)
            {
                for (t = num; t != 0; t = t / 10)
                {
                    r = t % 10;
                    sum = sum * 10 + r;
                }
                Console.Write("The number in reverse order is : {0} \n", sum);
                output += sum.ToString();
                sum = 0;
                Console.Write("Input a number: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("A sequence of reversed number: " + output);

            //TA Example
            /*
			string sequence = "";
			while(true){
				Console.Write("Enter a number: ");
				string number = Console.ReadLine();
				
				if(Convert.ToInt32(number)>=0){
					Console.Write("Reversed number: ");
					
					//由string最後一個index至第一個index
					for (int i=number.Length-1; i>=0; i--){
						Console.Write(number[i]);
						
						//string的加法就是合併
						sequence += number[i];
					}
					Console.Write("\n");
				}
				else{
					Console.WriteLine("A sequence of reversed number: " + sequence);
					break;
				}
			}
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
