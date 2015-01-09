using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.AdvancedBitExchange
{
    class Program
    {
        static void Main(string[] args)
        {

            long number = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());


            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            for (int i = p, j = q, l = k; (i <= 32 && j <= 32) && l > 0; i++, j++, l--)
            {
                if (((number >> 1) & 1) != ((number >> j) & 1))
                {
                    number = changeBits(number, i, j);
                }
            }
            Console.WriteLine(number);
            Console.WriteLine(Convert.ToString(number,2).PadLeft(32,'0'));

        }
        private static long changeBits(long number, int firstposition, int secondposition)
        {
            number ^= (1 << firstposition);
            return number ^ (1 << secondposition);
        }
    }
}
