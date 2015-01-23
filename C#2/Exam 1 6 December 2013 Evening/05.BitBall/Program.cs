using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitBall
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldLength = 8;
            int[,] matrix = new int[fieldLength, fieldLength];

            for (int i = 0; i < fieldLength; i++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int j = 0; j < fieldLength; j++)
                {
                    int bit = (number >> j) & 1;
                    if (bit == 1)
                    {
                        matrix[i, j] = 1;
                    }

                }
            }
            for (int i = 0; i < fieldLength; i++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int j = 0; j < fieldLength; j++)
                {
                    int bit = (number >> j) & 1;
                    if (bit == 1)
                    {
                        if (matrix[i, j] == 1)
                        {
                            matrix[i, j] = 0;
                        }
                        else
                        {
                            matrix[i, j] = 2;
                        }

                    }

                }
            }
            int counter1 = 0;
            int counter2 = 0;

            for (int col = 0; col < fieldLength; col++)
            {
                for (int row = 0; row < fieldLength; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        break;
                    }
                    else if (matrix[row, col] == 2)
                    {
                        counter2++;
                        break;
                    }
                }
            }

            for (int col = 0; col < fieldLength; col++)
            {
                for (int row = fieldLength - 1; row > 0; row--)
                {
                    if (matrix[row, col] == 1)
                    {
                        counter1++;
                        break;
                    }
                    else if (matrix[row, col] == 2)
                    {

                        break;
                    }
                }
            }
            Console.WriteLine("{0}:{1}", counter1, counter2);
        }
    }
}
