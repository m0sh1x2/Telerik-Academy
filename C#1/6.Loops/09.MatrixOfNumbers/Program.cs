using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MatrixOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < i+n; j++)
                {
                    Console.Write("{0,-4}",j);
                }
                Console.WriteLine();
            }


            
        }
    }
}
