using System;

class TriangleSurface
{

    static double GetAreaWIthAltitude(double a, double h)
    {
        return (a * h) / 2;
    }
    static double GetAreaWithHeron(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

    }
    static double GetAreaWithAngle(double a, double b, double alpha)
    {
        return (a * b * Math.Sin(Math.PI * alpha / 180)) / 2;
    }

    static void Main()
    {
        /*•	Write methods that calculate the surface of a triangle by given:
            o	Side and an altitude to it;
            o	Three sides;
            o	Two sides and an angle between them;
          •	Use System.Math.*/

        Console.WriteLine(GetAreaWIthAltitude(3, 4));
        Console.WriteLine(GetAreaWithHeron(3, 4, 5));
        Console.WriteLine(GetAreaWithAngle(3, 4, 100));
    }

}

