using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.QuadraticEquasion1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a : ");
            string int1 = Console.ReadLine();
            int a = int.Parse(int1);

            Console.Write("Enter b :");
            string int2 = Console.ReadLine();
            int b = int.Parse(int2);

            Console.Write("Enter c : ");
            string int3 = Console.ReadLine();
            int c = int.Parse(int3);

            double x1, x2;
            int d;
            d = b * b - 4 * a * c;


            if (d == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("The only solution is x={0}",x1);
                Console.ReadLine();
            }
            else if (d < 0)
            {
                Console.WriteLine("There are no possible solutions !");
                Console.ReadLine();
            }
            else
            { 
                x1 = (-b - Math.Sqrt(d)) / (2 * a);
                x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = {0} and x2={1}.", x1, x2);
                Console.ReadLine();
            }

        }
    }
}
