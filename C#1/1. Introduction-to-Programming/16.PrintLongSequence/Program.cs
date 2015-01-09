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
            var max = 1000;
            var number = -2;
            for (int i = 0; i < max; i++)
            {
                if (number % 2 != 0)
                {
                    if (i != max)
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
                   
                    if (i != max)
                    {
                        Console.Write(Math.Abs(number) + ",");
                    }
                    else
                    {
                        Console.Write(Math.Abs(number) + " ");
                    }
                }
                number--;
            }

        }
    }
}
