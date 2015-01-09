using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CheckThirdInt
{
    class Chec3rd
    {
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());
            number = number / 100;
            if (number % 10 == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
