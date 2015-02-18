﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BinaryToDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            string binary = Console.ReadLine();

            string[] result = new string[binary.Length];

            long converted = 0;


            for (int i = 0; i < binary.Length; i++)
            {
                result[i] = binary[i].ToString();
            }

            for (int i = 0; i < binary.Length; i++)
            {
                long parsed = int.Parse(result[i]);
                double power = Math.Pow(2, i);

                converted += (long)power;

            }

            Console.WriteLine(converted);

        }
    }
}