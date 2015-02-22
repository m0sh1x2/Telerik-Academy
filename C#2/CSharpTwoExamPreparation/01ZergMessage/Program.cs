using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ZergMessage
{
    class Program
    {
        static int numBase = 15;
        static void Main(string[] args)
        {

            string message = Console.ReadLine();

            long result = 0;
            long position = message.Length / 4 - 1;


            for (int i = 0; i < message.Length; i += 4)
            {
                var currentMessage = message.Substring(i, 4);

                result += ConvertMessage(currentMessage) * PowerOfFifteen(position);

                position--;
            }
            Console.WriteLine(result);

        }
        static long PowerOfFifteen(long power)
        {
            long result =1;

            for (long i = 0; i < power; i++)
            {
                result *= numBase;
            }

            return result;
        }
        private static long ConvertMessage(string message)
        {
            long result = 0;
            switch (message)
            {
                case "Rawr": result = 0; break;
                case "Rrrr": result = 1; break;
                case "Hsst": result = 2; break;
                case "Ssst": result = 3; break;
                case "Grrr": result = 4; break;
                case "Rarr": result = 5; break;
                case "Mrrr": result = 6; break;
                case "Psst": result = 7; break;
                case "Uaah": result = 8; break;
                case "Uaha": result = 9; break;
                case "Zzzz": result = 10; break;
                case "Bauu": result = 11; break;
                case "Djav": result = 12; break;
                case "Myau": result = 13; break;
                case "Gruh": result = 14; break;

            }

            return result;
        }
    }
}
