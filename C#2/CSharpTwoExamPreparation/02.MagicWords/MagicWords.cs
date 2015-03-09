using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.MagicWords
{
    class MagicWords
    {
        public static List<int> cages;

        static void Main(string[] args)
        {
            cages = Input();

            for (int stepNumber = 1; true; stepNumber++)
            {
                if (cages.Count < stepNumber)
                {
                    break;
                }

                var cagesCount = SumListVariablesInRange(cages, 0, stepNumber - 1);

                if (cages.Count < stepNumber + cagesCount)
                {
                    break;
                }
                var sum = SumListVariablesInRange(cages, stepNumber, cagesCount + stepNumber - 1);
                Console.WriteLine(sum);
                break;
            }




        }
        static long ProducstValuesInRange(List<int> list, int startIndex, int endIndex)
        {
            var product = 1;
            for (int i = startIndex; i < endIndex; i++)
            {
                product *= cages[i];
            }
            return product;
        }

        private static int SumListVariablesInRange(List<int> cages, int startIndex, int endIndex)
        {
            var sum = 0;
            for (int i = startIndex; i < endIndex; i++)
            {
                sum += cages[i];
            }
            return sum;
        }




        private static List<int> Input()
        {
            var list = new List<int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                list.Add(int.Parse(input));
            }

            return list;
        }
    }
}
