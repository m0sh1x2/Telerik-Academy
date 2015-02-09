using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {

             /*
             * 
             * 
             * 
              * Works only with positive numbers :(
             //the matrix input
                5
                6
                0, 0, 0, 0, 0, 0 
                0, 0, 0, 1, 0, 0 
                0, 0, 0, 0, 1, 0 
                0, 0, 0, 0, 0, 1 
                5, 6, 7, 8, 9, 9
             */
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int reduceLogic = n - m;
            int reduceLoop = n - 2 + reduceLogic;

            int[,] matrix = new int[n, m];
            for (int row = 0; row < n; row++)
            {
                string matrixInput = Console.ReadLine();
                matrixInput = matrixInput.Replace(",", "");
                matrixInput = matrixInput.Replace(" ", "");
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = int.Parse(matrixInput[col].ToString());
                    Console.Write(matrixInput[col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();




            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - reduceLoop; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - reduceLoop; col++)
                {

                    int sum =
                        //top
                        matrix[row, col] +
                        matrix[row + 1, col] +
                        matrix[row + 2, col] +
                        //middle
                        matrix[row, col + 1] +
                        matrix[row, col + 2] +
                        matrix[row + 1, col + 1] +
                        //last
                        matrix[row + 1, col + 2] +
                        matrix[row + 2, col + 1] +
                        matrix[row + 2, col + 2];

                    //int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine("The best platform is:");
            Console.WriteLine("  {0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
            Console.WriteLine("  {0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
            Console.WriteLine("  {0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
            Console.WriteLine("The maximal sum is: {0}", bestSum);

        }
    }
}
