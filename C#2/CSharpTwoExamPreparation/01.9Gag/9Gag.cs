using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01._9Gag
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            BigInteger result = 0;

            string partialInput = String.Empty;
            string theNumber = "";


            for (int i = 0; i < input.Length; i++)
            {
                partialInput += input[i];
                string currentDigit = CheckNumber(partialInput);

                if (currentDigit != "NO")
                {
                    theNumber += currentDigit;
                    partialInput = String.Empty;
                }
            }

            for (int i = 0; i < theNumber.Length; i++)
            {
                BigInteger digit = BigInteger.Parse(theNumber[i].ToString());
                result += digit * PowerOfNine(theNumber.Length - i - 1);
            }
            Console.WriteLine(result);

        }
        public static BigInteger PowerOfNine(BigInteger power)
        {
            BigInteger result = 1;
            for (BigInteger i = 0; i < power; i++)
            {
                result *= 9;
            }

            return result;
        }
        private static int NextCounter(string input)
        {
            int number = 0;

            switch (input)
            {
                case "-!": number = 2; break;
                case "**": number = 2; break;
                case "!!": number = 3; break;
                case "&&": number = 2; break;
                case "&-": number = 2; break;
                case "!-": number = 2; break;
                case "*!": number = 4; break;
                case "&*": number = 3; break;
                case "!!*": number = 6; break;
                //default: number = 6; break;
            }

            return number;
        }
        private static string CheckNumber(string input)
        {
            string result = "NO";

            switch (input)
            {
                case "-!": result = "0"; break;
                case "**": result = "1"; break;
                case "!!!": result = "2"; break;
                case "&&": result = "3"; break;
                case "&-": result = "4"; break;
                case "!-": result = "5"; break;
                case "*!!!": result = "6"; break;
                case "&*!": result = "7"; break;
                case "!!**!-": result = "8"; break;

            }

            return result;
        }
    }
}
