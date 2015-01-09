using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace _10.CircleAndRect
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Enter a value for x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for y: ");
            double y = double.Parse(Console.ReadLine());
            bool intheCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9;
            bool intheRectangle = ((-1 <= x) && (x <= 5)) && ((-1 <= y) && (y <= 1));
            if (intheCircle && !intheRectangle)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
