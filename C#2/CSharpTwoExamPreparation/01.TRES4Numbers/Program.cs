using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TRES4Numbers
{
    class Program
    {

        static void Main(string[] args)
        {
            ulong input = ulong.Parse(Console.ReadLine());
            var digits = new List<ulong>();

            if (input == 0)
            {
                Console.WriteLine(CheckNumber(0));
            }

            while (input > 0)
            {
                ulong digit = (ulong)(input % 9);
                digits.Add(digit);
                input /= 9;
            }
            digits.Reverse();
            foreach (var item in digits)
            {
                Console.Write(CheckNumber(item));
            }
            Console.WriteLine();
        }
        

        private static string CheckNumber(ulong input)
        {
            string theNumber = String.Empty;
            switch (input)
            {
                case 0: theNumber = "LON+"; break;
                case 1: theNumber = "VK-"; break;
                case 2: theNumber = "*ACAD"; break;
                case 3: theNumber = "^MIM"; break;
                case 4: theNumber = "ERIK|"; break;
                case 5: theNumber = "SEY&"; break;
                case 6: theNumber = "EMY>>"; break;
                case 7: theNumber = "/TEL"; break;
                case 8: theNumber = "<<DON"; ; break;
            }

            return theNumber;
        }
    }
}
