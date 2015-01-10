using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            decimal result = 1;

            for (int i = 1; i <= n; i++)
            {
                result += (decimal)fact(i) / (decimal)Math.Pow(x, i);
            }

            Console.WriteLine("{0:F5}",result);
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
