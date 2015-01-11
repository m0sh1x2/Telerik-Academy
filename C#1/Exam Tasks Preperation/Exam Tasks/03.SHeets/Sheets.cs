using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SHeets
{
    class Sheets
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());

            for (int i = 10; i >= 0; i--)
            {
                if ((n & 1) == 0)
                {
                    Console.WriteLine("A{0}",i);
                }

                n >>= 1;

            }
        }
    }
}
