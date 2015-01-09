using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PrintSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = -2;
            for (int i = 0; i < 10; i++)
            {
                if (number % 2 !=0)
                {         
                    if (i != 9)
                    {
                        Console.Write(number + ",");
                    }
                    else
                    {
                        Console.WriteLine(number + " ");
                    }
                }
                if (number % 2 == 0)
                {
                        Console.Write(Math.Abs(number) + ",");
                }
                number--;
            }
            
        }
    }
}
