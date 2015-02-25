namespace TRES4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    class TRES4
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            long num = long.Parse(input.ToString());

            string convertedInput = Convert.ToString(num, 8);

            StringBuilder str = new StringBuilder();

            for (int i = 0; i < convertedInput.Length + 1; i++)
            {
                switch (convertedInput.ToArray()[i])
                {
                    case '0': str.Append("LON+"); break;
                    case '1': str.Append("VK-"); break;
                    case '2': str.Append("*ACAD"); break;
                    case '3': str.Append("^MIM"); break;
                    case '4': str.Append("ERIK|"); break;
                    case '5': str.Append("SEY&"); break;
                    case '6': str.Append("EMY>>"); break;
                    case '7': str.Append("/TEL"); break;
                    case '8': str.Append("<<DON"); break;

                }
            }

            Console.WriteLine(str);
        }
    }
}