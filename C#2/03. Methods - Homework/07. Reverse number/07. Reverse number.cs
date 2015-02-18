using System;

class ReverseNumber
{
    static void Main()
    {
        //•	Write a method that reverses the digits of given decimal number.

        Console.WriteLine(Reverse(int.Parse(Console.ReadLine())));

    }
    public static int Reverse(int n)
    {
        int left = n;
        int rev = 0;
        while (left > 0)
        {
            int r = left % 10;
            rev = rev * 10 + r;
            left = left / 10;
        }
        return rev;
    }

}

