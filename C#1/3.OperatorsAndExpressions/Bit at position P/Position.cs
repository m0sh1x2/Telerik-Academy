using System;

class Position
{
    static void Main()
    {
        int v = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int bit =  int.Parse(Console.ReadLine());

        var mask = ~(1 << p);
        var result = v & mask;
        result = result & v;
        Console.WriteLine(Convert.ToString(result, 2));
    }
}