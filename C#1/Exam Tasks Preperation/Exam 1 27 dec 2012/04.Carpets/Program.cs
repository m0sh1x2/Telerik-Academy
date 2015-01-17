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

            int[,] carpet = new int[n, n];
            int startSlash = n / 2 - 1;
            int endSlash = n / 2 - 1;
            int counter = 0;


            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == counter && col == startSlash)
                    {
                        carpet[row, col] = 2;
                    }
                    if (row == counter && col == endSlash + 1)
                    {
                        carpet[row, col] = 3;
                    }



                }
                counter++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(carpet[i, j]);
                }
                Console.WriteLine();
            }




        }
    }
}
