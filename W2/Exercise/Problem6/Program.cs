/*
*Design a simple temperature transaction program and showing the assigned message
*03/09/2021
*/
using System;

namespace Problem6
{
    class Program
    {
        static int Main()
        {
            Boolean isEnd = true;
            Console.Write("temperature of Celsius:");

                try
                {
                    double degreesCelsius = Double.Parse(Console.ReadLine());
                    double degreesFahrenheit = 9 / 5 * degreesCelsius + 32;
                    if (degreesFahrenheit < -459.67)
                    {
                        throw new ArgumentException();
                    }
                    else if (degreesFahrenheit > 82.4)
                    {
                        Console.Write("It's hot!");
                        Console.Write(isEnd ? "\nEnd" : "\nSomething wrong, please check.");
                        Console.WriteLine("\nPress any key to exit...");
                        Console.ReadLine();
                    }
                    else if (degreesFahrenheit > 59.00)
                    {
                        Console.Write("It's warm!");
                        Console.Write(isEnd ? "\nEnd" : "\nSomething wrong, please check.");
                        Console.WriteLine("\nPress any key to exit...");
                        Console.ReadLine();
                    }
                    else if (degreesFahrenheit > 50.00)
                    {
                        Console.Write("It's cool!");
                        Console.Write(isEnd ? "\nEnd" : "\nSomething wrong, please check.");
                        Console.WriteLine("\nPress any key to exit...");
                        Console.ReadLine();
                    }
                    else if (degreesFahrenheit > 41.00)
                    {
                        Console.Write("It's chilly!");
                        Console.Write(isEnd ? "\nEnd" : "\nSomething wrong, please check.");
                        Console.WriteLine("\nPress any key to exit...");
                        Console.ReadLine();
                    }
                    else if (degreesFahrenheit > 32.00)
                    {
                        Console.Write("It's cold!");
                        Console.Write(isEnd ? "\nEnd" : "\nSomething wrong, please check.");
                        Console.WriteLine("\nPress any key to exit...");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("It's freezing!");
                        Console.Write(isEnd ? "\nEnd" : "\nSomething wrong, please check.");
                        Console.WriteLine("\nPress any key to exit...");
                        Console.ReadLine();
                    }
                    isEnd = true;
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("\nPress any key to exit...");
                    Console.ReadLine();
                }
    
                return isEnd ? 0 : -1;
        }
    }
}
