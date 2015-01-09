using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FindThirdBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 12;
                Console.Write("Third bit is : ");
                Console.WriteLine((number >> 3) & 1);
        }
    }
}
