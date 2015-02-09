using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FillTheMatrixA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int[,] matrix = new int[n, n];



            //Matrix A
            Console.WriteLine("Matrix A");
            int counter = 1;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[col, row] = counter;
                    counter++;
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,-4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix B");

            //Matrix B
            int[,] matrixB = new int[n, n];
            counter = 1;
            bool goUp = false;
            int lastCol = 0;
            string direction = "down";

            int rowB = 0, colB = 0;
            for (int i = 0; i < n * n; i++)
            {
                matrixB[rowB, colB] = counter;

                if (direction == "down" && rowB >= n - 1)
                {
                    direction = "up";
                    colB++;
                    rowB++;
                }
                if (direction == "up" && rowB <= 0)
                {
                    direction = "down";
                    colB++;
                    rowB--;

                }

                if (direction == "down")
                {
                    rowB++;
                }
                if (direction == "up")
                {
                    rowB--;
                }
                counter++;
            }


            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,-4}", matrixB[row, col]);
                }
                Console.WriteLine();
            }

            //Matrix C
            Console.WriteLine("Matrix C");
            int[,] matrixC = new int[n, n];
            counter = 1;
            int currentRow;

            for (int row = n - 1; row >= 0; row--)
            {
                currentRow = row;
                for (int col = 0; col < n - row; col++)
                {
                    matrixC[currentRow++, col] = counter++;
                }


            }
            counter = n * n;
            for (int row = 0; row < n - 1; row++)
            {
                currentRow = row;
                for (int col = n - 1; currentRow >= 0; col--)
                {
                    matrixC[currentRow--, col] = counter--;
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,-4}", matrixC[row, col]);
                }
                Console.WriteLine();
            }
            // Matrix D


        }
    }
}
