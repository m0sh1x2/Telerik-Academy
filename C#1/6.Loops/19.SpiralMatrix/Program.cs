using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];
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
                    Console.Write("{0,-4}", matrix[col, row]);

                }
                Console.WriteLine();
            }

        }
    }
}
