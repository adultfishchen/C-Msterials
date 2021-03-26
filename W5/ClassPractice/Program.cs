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
            Console.WriteLine("Enter fruit : ");
            string fuserinput = Console.ReadLine();
            string[] fruit = fuserinput.Split(' ');
            Console.WriteLine("Menu : ");
            foreach (string str1 in Base)
            {
                foreach (string str2 in fruit)
                {
                    Console.Write(str2 + str1 + "\t");
                }
                Console.WriteLine();
            }
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
            string[,] result=new string[size[0],size[1]]; 
            int index = 0, count = 0;
            for(int i = 0 ; i<size[0];i++)
            {
                for(int j = 0 ; j<size[1]; j++)
                {
                    result[i,j] = seats[index];
                    index++;
                    if(result[i,j]=="0")
                    {
                        count++;
                    }

                }
            }
           int min = count/3;
           if(min == 0)
           {
               min = 10;
           }
           else
           {
               min*=10;
           }
           Console.WriteLine("{0} minutes.",min);


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
