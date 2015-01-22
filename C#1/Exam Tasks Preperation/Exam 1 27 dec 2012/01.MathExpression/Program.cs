using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MathExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            double N = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());


            double result, sin;
            
            result = (N*N + (1.0/(M*P)) + 1337.0);
            result /= N - 128.523123123*P;
            result += Math.Sin((int)M%180);

            Console.WriteLine("{0:F6}",result);

        }
    }
}
