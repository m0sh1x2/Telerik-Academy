using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TribonacciTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long l = long.Parse(Console.ReadLine());
            long temp;

            Console.WriteLine(a);
            Console.WriteLine(b + " " + c);


            for (long i = 3; i < l + 2; i++)
            {
                if (!(i == l + 1))
                {
                    for (long j = 0; j < i; j++)
                    {
                        temp = a;
                        a = b;
                        b = c;
                        c = temp + a + b;
                        Console.Write(c + " ");
                    }

                    Console.WriteLine();
                }

            }
        }

    }
}
