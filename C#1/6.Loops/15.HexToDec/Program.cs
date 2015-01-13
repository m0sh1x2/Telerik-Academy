using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.HexToDec
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(n,16));
        }
    }
}
