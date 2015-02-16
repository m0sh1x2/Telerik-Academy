using System;

class GetLargestNumber
{
    static void Main()
    {
        /*•	Write a method GetMax() with two parameters that returns the larger of two integers.
          •	Write a program that reads 3 integers from the console and prints the largest of 
         * them using the method GetMax(). */
        Console.WriteLine(GetMax(1337, -1337));
    }

    public static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }

    }
}

