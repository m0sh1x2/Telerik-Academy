using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter number : ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter bit : ");
        int p = int.Parse(Console.ReadLine());
        int mask;
        int result = 0;
        mask = 1 << p;
        result = n & mask;
        Console.WriteLine("Binary representation of {0} : ", n);
        Console.WriteLine(Convert.ToString(n, 2));
        Console.WriteLine("Third bit : ");
        Console.WriteLine(result > 0 ? 1 : 0);

    }
}