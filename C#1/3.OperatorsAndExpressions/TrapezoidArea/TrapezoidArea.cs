using System;
using System.Globalization;
using System.Threading;
class TrapezoidArea
{
    static void Main(string[] args)
    {

        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        Console.WriteLine("Enter side a : ");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b : ");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter height : ");
        float h = float.Parse(Console.ReadLine());
        float part = (a + b) / 2;
        float area = part * h;
        Console.WriteLine("The area of the Trapezoid is : {0}",area);
    }
}

