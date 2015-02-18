﻿/*Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RepresetSingedShortInBinarty
{
    static void Main()
    {
        Console.Write("Enter value between {0} and {1}: ", short.MinValue, short.MaxValue);
        short number = short.Parse(Console.ReadLine());
        string binaryStr = ShortToBinary(number);
        int chunkSize = 4;
        int stringLength = binaryStr.Length;
        for (int i = 0; i < stringLength; i += chunkSize)
        {
            Console.Write(binaryStr.Substring(i, chunkSize) + " ");
        }
    }

    static string ShortToBinary(int x)
    {
        int index = 0;
        int counter = 0;
        char[] arr = new char[16];
        if (x > 0)
        {
            while (x != 0)
            {
                arr[index++] = (x & 1) == 1 ? '1' : '0';
                x >>= 1;
                counter++;
            }
            for (index = counter; index < arr.Length; index++)
            {
                arr[index] = '0';
            }
        }
        else
        {
            while (x != -1)
            {
                arr[index++] = (x & 1) == 1 ? '1' : '0';
                x >>= 1;
                counter++;
            }
            for (index = counter; index < arr.Length; index++)
            {
                arr[index] = '1';
            }
        }
        Array.Reverse(arr, 0, index);
        return new string(arr);
    }
}