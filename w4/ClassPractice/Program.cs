/*
* function1 : Number Triangle - Print a number triangle of range n, where n is a positive integer derived from user input.
* function2 : 中二 ID generator - To randomly generate a 中二 ID. Your ID may include prefix, postfix and infix. The content should be a combination of two words.
* function3 : Reverse Number - To reverse a positive number from user input. 
* 03/19/2021
*/

using System;

namespace ClassPractice
{
    class Program
    {
        static void function1()
        {
            int  i,j,k,l,n;           
            Console.Write("Enter the Range = ");    
            n= int.Parse(Console.ReadLine());     
            for(i=1; i<=n; i++)      
            {          
                //right side space
                for(j=1; j<=n-i; j++)      
                {      
                Console.Write(" ");      
                }

                //right side number
                for(k=1;k<=i;k++)      
                {      
                Console.Write(k);      
                }      

                //left side number
                for(l=i-1;l>=1;l--)      
                {      
                Console.Write(l);      
                }      
                Console.Write("\n");   
            }    
        }

        static void function2()
        {

        }

        static void function3()
        {
            int num,r,sum=0,t;
	
            Console.Write("\n\n");
            Console.Write("Display the number in reverse order:\n");
            Console.Write("--------------------------------------");
            Console.Write("\n\n");  	
            

            Console.Write("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine()); 	

            //依序取出各位、十位...的數值
            while(num>0)
            {
                for(t=num;t!=0;t=t/10)
                {
                    r=t % 10;
                    sum=sum*10+r;
                }
                Console.Write("The number in reverse order is : {0} \n",sum);
            }
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
