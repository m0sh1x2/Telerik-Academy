using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger result = fact(2 * n) / ((fact(n + 1)) * fact(n));
            Console.WriteLine(result);
        }
        private static BigInteger fact(int number)
        {
            BigInteger result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
