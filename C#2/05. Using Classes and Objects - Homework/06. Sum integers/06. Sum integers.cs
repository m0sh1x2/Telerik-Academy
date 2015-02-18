using System;

class SumIntegers
{
    static void Main()
    {
        //•	You are given a sequence of positive integer values written into a string, separated by spaces.
        //•	Write a function that reads these values from given string and calculates their sum.
        string integers = "1 2 3 4 5 6 7 8";
        CalcSum(integers);
    }
    public static void CalcSum(string integers)
    {
        var arrayOfInts = integers.Split();
        var result = 0;
        for (int i = 0; i < arrayOfInts.Length; i++)
        {
            result += int.Parse(arrayOfInts[i].ToString());
        }


        Console.WriteLine(result);
    }
}

