using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Zerg__
{
    class Program
    {
        const int NumeralSystemBase = 15;

        static int ConvertToDigit(string currentDigit)
        {

            switch (currentDigit)
            {
                case "Rawr": return 0; break;
                case "Rrrr": return 1; break;
                case "Hsst": return 2; break;
                case "Ssst": return 3; break;
                case "Grrr": return 4; break;
                case "Rarr": return 5; break;
                case "Mrrr": return 6; break;
                case "Psst": return 7; break;
                case "Uaah": return 8; break;
                case "Uaha": return 9; break;
                case "Zzzz": return 10; break;
                case "Bauu": return 11; break;
                case "Djav": return 12; break;
                case "Myau": return 13; break;
                case "Gruh": return 14; break;
                default: throw new ArgumentException();

            }

        }
        static long PowerOfFifteen(int power)
        {
            long result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= NumeralSystemBase;
            }

            return result;
        }
        static void Main(string[] args)
        {

            //Find elements in column or diagonal !

            string zergMessage = Console.ReadLine();
            int position = zergMessage.Length / 4 - 1;
            long result = 0;

            for (int i = 0; i < zergMessage.Length; i += 4)
            {
                string currentDigit = zergMessage.Substring(i, 4);

                result += ConvertToDigit(currentDigit) * PowerOfFifteen(position);

                position--;
            }

            Console.WriteLine(result);
        }
    }
}
