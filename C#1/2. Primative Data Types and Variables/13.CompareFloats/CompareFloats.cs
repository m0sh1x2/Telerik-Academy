using System;
using System.Threading;
using System.Globalization;


class CompareFloats
{


    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double bigger, smaller;
        //Set bigger and smaller vals
        if (a>b)
        {
            bigger = a;
            smaller = b;
        }
        else
        {
            bigger = b;
            smaller = a;
        }
        double dif = bigger - smaller;
        double eps = 0.000001;
        dif = Math.Abs(dif);
        if (dif < eps)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

