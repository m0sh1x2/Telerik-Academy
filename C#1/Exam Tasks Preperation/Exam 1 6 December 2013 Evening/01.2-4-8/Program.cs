using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._2_4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            long A = long.Parse(Console.ReadLine());
            long B = long.Parse(Console.ReadLine());
            long C = long.Parse(Console.ReadLine());
            long result = 0;
            long aAndC = 0;
            if (B == 2)
            {
                result = A % C;
            }
            if (B == 4)
            {
                result = A + C;
            }
            if (B == 8)
            {
                result = A * C;
            }

            if (result % 4 == 0)
            {
                aAndC = result;
                result /= 4;
                Console.WriteLine(result);
                Console.WriteLine(aAndC);
            }
            else
            {
                Console.WriteLine(result%4);
                Console.WriteLine(result);
                
            }


            
        }
    }
}
