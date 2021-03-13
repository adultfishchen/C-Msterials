/* 
 *           2    2    2
 * 利用尋找 x  + y  = z  之解
 * 示範在迴圈中使用break敘述
 * 03/12/2021
 */

using System;

namespace UsingBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            int n = 0;
            for(x = 1; x <=100 ; ++x)
            {
                for(y = x ; y <= 100; ++y)
                {
                    for(z = 1; z <= 150 ; ++z)
                    {
                        if(x * x + y *y == z * z)
                        {
                            ++n;
                            Console.WriteLine("{0} : {1} * {1} + {2} * {2} = {3}", n, x, y, z);
                            break;
                        }
                    }
                    if(n == 10) break;
                }
                if(n == 10) break;
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
