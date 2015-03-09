using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.BunnyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var cages = ReadInput();
            var result = new StringBuilder();


            for (int cageCount = 1; true; cageCount++)
            {
                if (cages.Count < cageCount)
                {
                    Console.WriteLine(String.Join(" ", cages));
                    break;
                }

                //get cage count
                int cageSum = 0;
                for (int i = cageCount - 1; i >= 0; i--)
                {
                    cageSum += (int)cages[i];
                }

                if (cageSum > cages.Count || cageSum < cageCount)
                {
                    Console.WriteLine(String.Join(" ", cages));
                    break;
                }
                //get next cages from cage sum
                var currentSum = GetSumOfCages(cageCount, cageSum + cageCount - 1, cages);
                var currentProduct = GetProductOfCages(cageCount, cageSum + cageCount - 1, cages);
                // get the remaining cages
                var remainingCages = GetRemainingCages(cageCount + cageSum, cages.Count, cages);


                result.Append(currentSum.ToString());
                result.Append(currentProduct.ToString());
                result.Append(remainingCages);


                // remove 1 and 0 es
                var theResult = result.ToString().Replace("1", string.Empty).Replace("0", string.Empty);
                // fill the next cages and clear the sb 


                result.Clear();
                cages.Clear();
                foreach (var item in theResult)
                {
                    cages.Add(ulong.Parse(item.ToString()));
                }


            }


        }
        public static string GetRemainingCages(int start, int end, List<ulong> list)
        {
            var result = new StringBuilder();
            for (int i = start; i < end; i++)
            {
                result.Append(list[i]);
            }
            return result.ToString();
        }

        public static ulong GetProductOfCages(int start, int end, List<ulong> list)
        {
            ulong result = 1;
            for (int i = start; i <= end; i++)
            {
                result *= list[i];
            }
            return result;
        }

        public static BigInteger GetSumOfCages(int start, int end, List<ulong> list)
        {
            BigInteger result = 0;
            for (int i = start; i <= end; i++)
            {
                result += list[i];
            }
            return result;
        }

        private static List<ulong> ReadInput()
        {
            var result = new List<ulong>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                result.Add(ulong.Parse(input));
            }

            return result;
        }
    }
}
