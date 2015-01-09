using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.GetMoreNNumbers
{
    class MoreN
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number :");
            string n = Console.ReadLine();
            long intN = long.Parse(n);
            long sum = intN + intN;
            for (int i = 0; i < 100;)
            {
                Console.Write( sum + "\r"  );
                sum = sum + sum;
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
