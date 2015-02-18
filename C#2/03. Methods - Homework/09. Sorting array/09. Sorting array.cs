using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        /*•	Write a method that return the maximal element in a portion of array of integers starting 
         *  at given index.
          •	Using it write another method that sorts an array in ascending / descending order.*/
        var array = new int[] { 1, 2, 3, 4, 9, 5, 6, 7, 8 };
        Console.WriteLine(maxElement(array, 1, 8));

    }
    public static int maxElement(int[] array, int from, int to)
    {
        int max = int.MinValue;
        for (int i = from; i < to; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
    public static IOrderedEnumerable<int> sortAscDesc(int[] array, string order)
    {
        var result = array.OrderByDescending(x => x);

        return result;
    }

}
