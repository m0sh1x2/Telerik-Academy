using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Carpets
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            int n = 12;

            int startSlash = n / 2 - 1;
            int endSlash = n / 2 - 1;
            int counter = 0;
            bool isSlash = true;
            int[,] carpet = new int[n, n];

            for (int row = 0; row < n/2; row++)
            {
                for (int col = 0; col < n/2; col++)
                {
                    if (startSlash <= col && col<= endSlash)
                    {
                        if (isSlash)
                        {
                            carpet[row, col] = 2;
                            carpet[row, n - 1 - col] = 3;
                            carpet[n - 1 - row, col] = 3;
                            carpet[n - 1 - row, n - 1 - col] = 2;
                            isSlash = false;
                        }
                        else
                        {

                        }
                    }
                }
                isSlash = true;
                startSlash++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(carpet[i,j]);
                }
                Console.WriteLine();
            }
            



        }
    }
}
