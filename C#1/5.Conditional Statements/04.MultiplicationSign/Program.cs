using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int sign = 0;
            int a = int.Parse(Console.ReadLine());
            sign += checkStatus(a);
            int b = int.Parse(Console.ReadLine());
            sign += checkStatus(b);
            int c = int.Parse(Console.ReadLine());
            sign += checkStatus(c);

            if (sign >= 10)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (sign%2 ==0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
        }
        private static int checkStatus(int number)
        {
            if (number < 0)
            {
                return 0;
            }
            if (number > 0)
            {
                return 1;
            }
            return 0;
        }
    }
}
