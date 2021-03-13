/*
*Design an program to calculate BMI
*03/04/2021
*/

using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Height(meter) : ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your Weight(Kg) : ");
            double weight = double.Parse(Console.ReadLine());
            double BMI = weight/Math.Pow(height,2.0);
            Console.WriteLine("Your BMI : " + BMI);

            Console.WriteLine();
            Console.WriteLine("Please pressany key to exit ...");
            Console.ReadKey();
        }
    }
}