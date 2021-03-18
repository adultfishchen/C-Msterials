/* 
 * 以下列三角矩陣
 * 
 * / 1                 \
 * | 2  21             |
 * | 3   6  31         |
 * | 4   7   9  41     |
 * \ 5   8  10  11  51 /
 * 
 * 示範不規則二維陣列之使用
 * 
 * 03/18/2021
 */

using System;

namespace Array2DA
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N_ROW = 5;
            int[][] lowerTriangularMatrix = new int[N_ROW][];
            for (int i = 0; i < N_ROW; ++i)
            {
                lowerTriangularMatrix[i] = new int[i + 1];
            }
            lowerTriangularMatrix[0][0] = 1;

            lowerTriangularMatrix[1][0] = 2;
            lowerTriangularMatrix[1][1] = 21;

            lowerTriangularMatrix[2][0] = 3;
            lowerTriangularMatrix[2][1] = 6;
            lowerTriangularMatrix[2][2] = 31;

            lowerTriangularMatrix[3][0] = 4;
            lowerTriangularMatrix[3][1] = 7;
            lowerTriangularMatrix[3][2] = 9;
            lowerTriangularMatrix[3][3] = 41;

            lowerTriangularMatrix[4][0] = 5;
            lowerTriangularMatrix[4][1] = 8;
            lowerTriangularMatrix[4][2] = 10;
            lowerTriangularMatrix[4][3] = 11;
            lowerTriangularMatrix[4][4] = 51;

            for (int i = 0; i < N_ROW; i++)
            {
                for (int j = 0; j < lowerTriangularMatrix[i].Length; j++)
                {
                    Console.Write(lowerTriangularMatrix[i][j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
