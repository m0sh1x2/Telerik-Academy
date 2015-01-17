using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TelerikLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = X;
            int Z = (X / 2) + 1;

            int width = (Z * 2 + Y * 2) - 3;
            int height = (Z * 2 + Y * 2) - 3;

            int row = X / 2;
            int col = 0;

            int[,] matrix = new int[width, height];


            // Solution
            while (true)
            {
                matrix[row, col] = 1;
                row--;
                col++;
                if (row < 0)
                {
                    row++;
                    col--;
                    break;
                }

            }
            while (true)
            {
                matrix[row, col] = 1;
                row++;
                col++;

                if (col > width - X / 2 - 1)
                {
                    row--;
                    col--;
                    break;
                }
            }

            while (true)
            {
                matrix[row, col] = 1;
                col--;
                row++;

                if (row > width - 1)
                {
                    col++;
                    row--;
                    break;
                }
            }

            while (true)
            {

                matrix[row, col] = 1;
                row--;
                col--;
                if (col < X / 2)
                {
                    row++;
                    col++;
                    break;
                }

            }
            while (true)
            {
                matrix[row, col] = 1;
                row--;
                col++;
                if (row < 0)
                {
                    row++;
                    col--;
                    break;
                }
            }
            while (true)
            {
                matrix[row, col] = 1;
                row++;
                col++;

                if (col > width - 1)
                {
                    break;
                }

            }

            // print

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        Console.Write(".");
                    }
                    else if (matrix[i, j] == 1)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
