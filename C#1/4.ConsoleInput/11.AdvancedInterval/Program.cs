using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AdvancedInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i < end; i++)
            {
                if (i%5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
