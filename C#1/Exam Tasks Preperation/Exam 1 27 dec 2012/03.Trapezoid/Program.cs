using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstCounter = n-1;
            int secondCounter = n-1;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string('.', n));
                    Console.Write(new string('*', n));
                }
                else
                {   
                        Console.Write(new string('.', firstCounter));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('.', secondCounter));
                        Console.Write(new string('*', 1));
                        secondCounter++;
                        firstCounter--;       
                }

                Console.WriteLine();
            }
            Console.Write(new string('*', n * 2));
            Console.WriteLine();
        }
    }
}
