/*
*Find Narcissistic Number, this exercise is assigned to find in the range of 100 to 999
*use the Euclidean algorithm to find out GCD, then calculate LCM
*Fibonacci Sequence and Golden Ratio
*03/12/2021
*/

using System;

namespace Problem9
{
    class Program
    {
        /* for multi-digit number
        // function to count digits
        int countDigit(int n)
        {
            if (n == 0)
                return 0;
        
            return 1 + countDigit(n / 10);
        }
        
           // Returns true if n is Narcissistic number
        bool check(int n)
        {
            // count the number of digits
            int l = countDigit(n);
            int dup = n;
            int sum = 0;
        
            // calculates the sum of 
            //digits raised to power
            while(dup > 0) 
            {
                sum += (int)Math.Pow(dup % 10, l);
                dup /= 10;
            }
     
            return (n == sum);
        }
        */

        static void Easy()
        {
            bool check(int n)
            {
                int dup = n;
                int sum = 0;
            
                // calculates the sum of 
                //digits raised to power
                while(dup > 0) 
                {
                    sum += (int)Math.Pow(dup % 10, 3);
                    dup /= 10;
                }
        
                return (n == sum);
            }

            int n; 
            for( n = 100 ; n <= 999 ; n ++)
            {
                if (check(n))
                Console.WriteLine("{0} is a 3-Narcissistic Number",n);
            }
        }

        static void Medium()
        {
            int lcm = 0;
            Console.WriteLine("Please enter the first positive integer : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the second positive integer : ");
            int y = Convert.ToInt32(Console.ReadLine());
            int num1 = x;
            int num2 = y;
            
            if (num1 < 0 || num2 < 0)
            {
                Console.WriteLine("Value out of range.");
            }
            else if (num1 < num2) 
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }
            int remainder;
            while (num2 != 0)
            {
                remainder = num1 % num2;
                num1 = num2;
                num2 = remainder;
                Console.WriteLine("GCD of these two positive integer is {0}", num1);
                lcm = x * y / num1;
                Console.WriteLine("LCM of these two positive integer is {0}", lcm);
            }           
        }
        
        static void Hard()
        {
            int input = 0;
            ulong f0 = 0, f1 = 1, fi = 0;
            Console.WriteLine("Please enter an integer between 3 to 90 : ");
            input = int.Parse(Console.ReadLine());
            double ratio;
    
                for(int i = 0; i<1;i++)
                {
                    fi = f1 + f0;
                    Console.WriteLine("F({0}) = {1}, ratio = {2}",i+1,fi,0);
                }
                for (int i = 1; i < input; i++)
                {
                    fi = f1 + f0;
                    f0 = f1;
                    f1 = fi;
                    ratio = (double)f1/f0;
                    Console.WriteLine("F({0}) = {1}, ratio = {2}",i+1,fi,ratio);
                }            
        }
        
        static void Main(string[] args)
        {
            Easy();
            Console.WriteLine();
            Medium();
            Console.WriteLine();
            Hard();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
            
        }

    }
}
