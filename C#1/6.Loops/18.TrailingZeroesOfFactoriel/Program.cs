using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _18.TrailingZeroesOfFactoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int sum = 0;
            int power = 5;
            do
            {
                sum += (input / 5);
            } while (power < 5);
            Console.WriteLine(sum);

        }

    }
}
