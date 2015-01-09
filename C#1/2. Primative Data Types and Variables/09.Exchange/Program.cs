using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        int buffer = 0;
        Console.WriteLine(a + " " + b);
        buffer = a;
        a = b;
        b = buffer;
        Console.WriteLine(a + " " + b);

    }
}

