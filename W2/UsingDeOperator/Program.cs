/*
*example for decreasing and increasing operator
*03/04/2021
*/

using System;

namespace UsingDeOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an int to initialize the variable x : ");
            int x0 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter an int to set the increment : ");
            int add = int.Parse(Console.ReadLine());
            int x = x0;
            x = x + add;            
            Console.WriteLine(
             "使用運算式\"x = x + add\" 運算結果等於{0} ", x);
            x = x0;
            x += add;
            Console.WriteLine(
             "使用運算式\"x += add\" 運算結果等於{0} ", x);
            int post;
            x = x0;
            post = x++;
            Console.WriteLine(
             "使用運算式\"post = x++後\" post 等於{0} ", post);
             Console.WriteLine(
              "使用運算式\"post = x++後\" x等於{0}", x);
            int pre;
            x = x0;
            pre=++x;
            Console.WriteLine(
             "使用運算式\"pre=++x後\" pre 等於{0} ", pre);
             Console.WriteLine(
              "使用運算式\"pre=++x後\" x等於{0}", x);

            Console.ReadKey();           
        }
    }
}
