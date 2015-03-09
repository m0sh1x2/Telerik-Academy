using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TheyAreGreen
{
    class Program
    {

        static void Main(string[] args)
        {

            ulong input = ulong.Parse(Console.ReadLine());

            var digits = new List<ulong>();
            var result = new StringBuilder();


            if (input == 0)
            {
                result.Append(ConvertNumber(0));
            }


            while (input > 0)
            {
                digits.Add(input % 9);
                input /= 9;
            }


            digits.Reverse();
            foreach (var item in digits)
            {
                result.Append(ConvertNumber(item));
            }


            Console.WriteLine(result.ToString());
        }
        public static string ConvertNumber(ulong number)
        {
            string result = String.Empty;

            switch (number)
            {
                case 0: result = "LON+"; break;
                case 1: result = "VK-"; break;
                case 2: result = "*ACAD"; break;
                case 3: result = "^MIM"; break;
                case 4: result = "ERIK|"; break;
                case 5: result = "SEY&"; break;
                case 6: result = "EMY>>"; break;
                case 7: result = "/TEL"; break;
                case 8: result = "<<DON"; break;
            }
            return result;

        }
    }
}
