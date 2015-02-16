﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ArrayVariations
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int conv;
        for (int i = 0; i < Math.Pow(n, k); i++)
        {
            conv = i;
            int[] array = new int[k];
            for (int j = 0; j < k; j++)
            {
                array[k - j - 1] = conv % n;
                conv = conv / n;
            }
            Console.Write("{0}{1}", '{', array[0] + 1);
            for (int j = 1; j < k; j++)
            {
                Console.Write(", {0}", array[j] + 1);
            }
            Console.WriteLine("}");
        }
    }
}