using System;
using System.Threading;
using System.Globalization;
class MoonGravity
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double gravity = double.Parse(Console.ReadLine());

        gravity = 17.0/100.0 * gravity;
        Console.WriteLine(gravity);

    }
}

