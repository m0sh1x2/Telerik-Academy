using System;

class LargerThanNeighbours
{
    static void Main()
    {
        //•	Write a method that checks if the element at given position in given array of integers is larger than 
        //  its two neighbours (when such exist).
        var array = new int[] { 1,5, 3, 4, 5, 6 };

        Console.WriteLine(CheckElementNeighbour(array,1));

    }
    public static bool CheckElementNeighbour(int[] array, int position)
    {
        if (position == 0)
        {
            return false;
        }
        else if (position == array.Length)
        {
            return false;
        }
        else
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

