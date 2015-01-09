using System;

class SumAccuracy
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        Console.WriteLine("Please enter the amount of numbers : ");
        int amount = int.Parse(Console.ReadLine());
        double number = 0;
        for (int i = 0; i < amount; i++)
        {   

            number += double.Parse(Console.ReadLine());
        }
        Console.WriteLine(number);
    }
}