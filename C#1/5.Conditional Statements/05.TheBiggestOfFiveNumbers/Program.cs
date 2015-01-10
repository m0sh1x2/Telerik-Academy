using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.GreatestOfFive
{
    class Greatest
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            double greatestNumber = a;
            if (greatestNumber < b)
            {
                greatestNumber = b;
            }
            if (greatestNumber < c)
            {
                greatestNumber = c;
            }
            if (greatestNumber < d)
            {
                greatestNumber = d;
            }
            if (greatestNumber < e)
            {
                greatestNumber = e;
            }
            Console.WriteLine("The greatest number is {0}", greatestNumber);
        }
    }
}
