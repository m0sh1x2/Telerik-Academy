using System;
using System.Numerics;
class NFactorial
{
    static void Main()
    {
        //•	Write a program to calculate n! for each n in the range [1..100].
        //Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
        Console.WriteLine(fact(BigInteger.Parse(Console.ReadLine())));
    }
    public static BigInteger fact(BigInteger n)
    {
        BigInteger result = 1;
        for (BigInteger i = 1; i < n; i++)
        {
            result *= i;
        }
        return result;
    }
}
