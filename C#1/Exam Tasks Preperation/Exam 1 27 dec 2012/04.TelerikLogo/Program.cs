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
            int X = 5;
            int Y = X;
            int Z = (X / 2) + 1;

            int width = (Z * 2 + Y * 2) - 3;
            int height = (Z * 2 + Y * 2) - 3;

            int currentCol = (X / 2);
            int currentRow = 0;

            int[,] matrix = new int[height, width];

            Console.WriteLine(width);

            while (true)
            {
                matrix[currentRow, currentCol] = 1;

                currentCol--;
                currentRow++;
                if (currentCol < 0)
                {
                    currentCol++;
                    currentRow--;
                    break;
                }

            }
            while (true)
            {
                matrix[currentRow, currentCol] = 1;

                currentCol++;
                currentRow++;
                if (currentRow == (width/2) +1)
                {

                    break;
                }

            }








            // print

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        Console.Write(".");
                    }
                    else if (matrix[row, col] == 1)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
