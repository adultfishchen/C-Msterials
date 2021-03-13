/*
 *       2    2    2
 * 尋找 x  + y  = z  的前n組正整數解
 * 03/12/2021
 */

using System;

namespace Pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            int n = 0;

            for(x = 1 ; x <= 100 ; ++x)
            {
                for(y = x ; y <= 100 ; ++y)
                {
                    for(z = 1 ; z <= 150 ; ++z)
                    {
                        if(x * x + y * y == z * z)
                        {
                            ++n;
                            if(n <= 10)
                            {
                                Console.WriteLine("{0} : {1} * {1} + {2} * {2} = {3} * {3}", n, x, y, z);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
