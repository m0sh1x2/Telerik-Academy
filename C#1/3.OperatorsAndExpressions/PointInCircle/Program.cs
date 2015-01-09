using System;

class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int radius = 2;
        bool result = x * x + y * y <= radius * radius;
        Console.WriteLine(result);
    }
}
