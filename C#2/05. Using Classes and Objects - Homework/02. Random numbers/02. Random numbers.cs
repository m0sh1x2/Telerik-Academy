using System;
using System.Text;

class RandomNumbers
{
    static void Main()
    {
        //•	Write a program that generates and prints to the console 10 random values in the range [100, 200].
        var random = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(random.Next(100,200));
        }
    }
}

