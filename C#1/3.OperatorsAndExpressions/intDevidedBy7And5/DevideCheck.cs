using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intDevidedBy7And5
{
    class DevideCheck
    {
        static void Main(string[] args)
        {
            
            for (int a = 0; a < 100; a++)
            {
                if (a % 5 == 0 && a % 7 == 0)
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("{0} is devidable by 7 and 5 ", a);
                    Console.WriteLine("---------------------------");
                }
                else
                {
                    Console.WriteLine("{0} is not devidable by 7 and 5", a);
                }
            }
           
        }
    }
}
