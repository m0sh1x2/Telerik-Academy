using System;

class CompareFloatingPointNumbers
{
    static void Main(string[] args)
    {

        float a = 5.3f;
        float b = 6.01f;

        float c = 5.000000001f;
        float d = 5.000000003f;

        Boolean compare = Math.Abs(a) == Math.Abs(b);
        Console.WriteLine("Compare \"a\" and \"b\" " + compare);

        Boolean compare2 = Math.Abs(c) == Math.Abs(d);
        Console.WriteLine("Compare \"c\" and \"d\" "+ compare2);

    }
}