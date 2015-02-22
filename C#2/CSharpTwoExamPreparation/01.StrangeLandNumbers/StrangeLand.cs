using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StrangeLandNumbers
{
    class StrangeLand
    {
        static void Main(string[] args)
        {


            string input = Console.ReadLine();

            long counter = 0;
            long result = 0;
            long power = input.Length / 3 - 1;
            while (counter <= input.Length - 1)
            {
                long nextLength = NextCounter(input[(int)counter]);
                //get the length of the number
                string currentNumber = input.Substring((int)counter, (int)nextLength);

                long thePower = PowerOfSeven(power);
                result += ConvertNumber(currentNumber) * thePower;

                counter += nextLength;

                power--;
            }
            Console.WriteLine(result);
        }

        private static long PowerOfSeven(long power)
        {
            long result = 1;
            for (long i = 0; i < power; i++)
            {
                result *= 7;
            }

            return result;
        }
        private static long ConvertNumber(string p)
        {
            long result = 0;

            switch (p)
            {
                case "f": result = 0; break;
                case "bIN": result = 1; break;
                case "oBJEC": result = 2; break;
                case "mNTRAVL": result = 3; break;
                case "lPVKNQ": result = 4; break;
                case "pNWE": result = 5; break;
                case "hT": result = 6; break;

            }

            return result;
        }

        private static long NextCounter(char p)
        {
            long result = 0;

            switch (p)
            {
                case 'f': result = 1; break;
                case 'b': result = 3; break;
                case 'o': result = 5; break;
                case 'm': result = 7; break;
                case 'l': result = 6; break;
                case 'p': result = 4; break;
                case 'h': result = 2; break;

            }

            return result;
        }
    }
}
