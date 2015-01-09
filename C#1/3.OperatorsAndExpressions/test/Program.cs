using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int mask = 3 >> 5;
            Console.WriteLine(Convert.ToString(mask,2));
        }
    }
}
