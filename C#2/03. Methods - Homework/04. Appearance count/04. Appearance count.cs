using System;

class AppearanceCount
{
    static void Main()
    {
        //•	Write a method that counts how many times given number appears in given array.
        //•	Write a test program to check if the method is workings correctly.
        var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 7, 8, 8, 7, 7 };
        Console.WriteLine(CheckForNumber(array, 7));
    }

    public static int CheckForNumber(int[] array, int number)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                result++;
            }
        }

        return result;
    }
}
