using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FOrmulaBitOne
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[8, 8];

            for (int i = 0; i < 8; i++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int j = 0; j < 8; j++)
                {
                    int bit = (number >> j) & 1;
                    matrix[i, j] = bit;
                }
            }
            int row = 0;
            int col = 0;
            bool endFound = false;
            string direction = "down";
            string lastDirection = "down";
            int directionCount = 0;
            int counter = 0;

            while (!endFound)
            {
                if (matrix[row, col] == 1)
                {
                    break;
                }
                counter++;
                if (col == 7 && row == 7)
                {
                    endFound = true;
                    break;
                }

                matrix[row, col] = 2;

                if (direction == "down" && (row + 1 > 7 || matrix[row + 1, col] == 1))
                {
                    direction = "left";
                    lastDirection = "down";
                    directionCount++;

                    if (col + 1 > 7 || matrix[row, col + 1] == 1)
                    {
                        break;
                    }
                }
                if (direction == "up" && (row - 1 < 0 || matrix[row - 1, col] == 1))
                {
                    direction = "left";
                    lastDirection = "up";
                    directionCount++;
                    if (col + 1 > 7 || matrix[row, col + 1] == 1)
                    {
                        break;
                    }
                }
                if (direction == "left" && lastDirection == "down" && (col + 1 > 7 || matrix[row, col + 1] == 1))
                {
                    direction = "up";
                    lastDirection = "left";
                    directionCount++;
                }
                if (direction == "left" && lastDirection == "up" && (col + 1 > 7 || matrix[row, col + 1] == 1))
                {
                    lastDirection = "up";
                    direction = "down";
                    directionCount++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "up")
                {
                    row--;
                }
                if (direction == "left")
                {
                    col++;
                }
            }

            if (endFound)
            {

                Console.WriteLine(counter + " " + directionCount);
            }
            else
            {
                Console.WriteLine("No " + counter);
            }

        }
    }
}
