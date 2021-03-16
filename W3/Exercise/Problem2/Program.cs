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

            /*TA_Solution 1(recommend)*/
            /*for(int num=100; num<1000 ;num++){//num從100跑到999
                int digit1=(num/100)%10;//取得 num 的百位數字
                int digit2=(num/10)%10;//取得 num 的十位數字
                int digit3=num%10;//取得 num 的個位數字                
                int sum = digit1*digit1*digit1 + digit2*digit2*digit2 + digit3*digit3*digit3;//算出每個digit的3次方的總和
                //計算次方也可以使用如下 Math.Pow(x,y)  即可得到 x 的 y 次方, 要注意回傳型態是double
                //double sum =Math.Pow(digit1,3)+Math.Pow(digit2,3)+Math.Pow(digit3,3);
                if(sum==num){//判斷是否等於 num 自己本身
                    Console.WriteLine("{0} is a 3-Narcissistic number.", num);
                }
            }*/
            /*TA_Solution 2*/
            /*
            for(int digit1=1;digit1<=9;digit1++){//百位數字從1~9
                for(int digit2=0;digit2<=9;digit2++){//十位數字從0~9
                    for(int digit3=0;digit3<=9;digit3++){//個位數字從0~9
                        int num = digit1*100+digit2*10+digit3;//還原該數字
                        int sum = digit1*digit1*digit1 + digit2*digit2*digit2 + digit3*digit3*digit3;//算出每個digit的3次方的總和
                        if(sum==num){
                            Console.WriteLine("{0} is a 3-Narcissistic number.", num);
                        }
                    }
                }
            }
            */  
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

            /*TA_Solution1:輾轉相除(recommend)*/
            /*Console.Write("Please enter num1:");
            int num1 = int.Parse(Console.ReadLine());//讀取整數可以使用int.Parse()
            Console.Write("Please enter num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());//也可以使用Convert.ToInt()
            if(num1>0 && num2>0){//檢查輸入的數字是否皆大於0
                int remainder, x=num1,y=num2;
                while(y!=0){//輾轉相除法, 參考講義Chapter 4.11
                    remainder=x%y;
                    x=y;
                    y=remainder;
                }
                int GCD=x, LCM=num1*num2/x;//最小公倍數=兩個輸入相乘再除以最大公因數
                Console.WriteLine("The Greatest Common Divisor of {0} and {1} is {2}", num1, num2, GCD);
                Console.WriteLine("The Least Common Multiple of {0} and {1} is {2}", num1, num2, LCM);
            }
            else{//num1或num2為負數或0
                Console.WriteLine("Value Out of Range.");
            }*/
            /*TA_Solution2*/
            /*
            Console.Write("Please enter num1:");
            int num1 = int.Parse(Console.ReadLine());//讀取整數可以使用int.Parse()
            Console.Write("Please enter num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());//也可以使用Convert.ToInt()
            if(num1>0 && num2>0){//檢查輸入的數字是否皆大於0
                int GCD=1, LCM=1;
                for(int i=1;i<=num1 && i<=num2;i++){//從1開始檢查每一個數字是否整除num1和num2
                    if(num1%i==0 && num2%i==0)
                        GCD=i;                
                }
                LCM=num1*num2/GCD;
                Console.WriteLine("The Greatest Common Divisor of {0} and {1} is {2}", num1, num2, GCD);
                Console.WriteLine("The Least Common Multiple of {0} and {1} is {2}", num1, num2, LCM);
            }
            else{//num1或num2為負數或0
                Console.WriteLine("Value Out of Range.");
            }
            */          
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

            /*TA_Solution*/
            /*Console.Write("Enter N:");
            int n = int.Parse(Console.ReadLine());
            double Fib1=1, Fib2=1, temp;//ulong型態也可
            Console.WriteLine("F({0})={1}, ratio={2}",1,Fib1,0);//顯示F(1)=1, ratio=0 (注意F1前一項為0, 記得不要除以0!!)
            Console.WriteLine("F({0})={1}, ratio={2}",2,Fib2, Fib2/Fib1);//顯示F(2)=1, ratio=1
            if(n>=3){                
                for(int i=3;i<=n;i++){//此迴圈計算出第 i 個Fibonacci number以及ratio並顯示
                    temp=Fib2;
                    Fib2=Fib1+Fib2;
                    Fib1=temp;
                    Console.WriteLine("F({0})={1}, ratio={2}",i,Fib2,Fib2/Fib1);//輸出F(3)~F(N)
                }                
            }
            else if(n<=0){
                Console.WriteLine("Value Out of Range");
            }*/            
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
