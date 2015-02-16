using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            int
                startIndex = 0,
                currentSum = 0,
                bestSum = int.MinValue,
                bestStart = 0,
                bestEnd = 0,
                length = array.Length;

            for (int i = 0; i < length; i++)
            {
                if (currentSum <= 0)
                {
                    startIndex = i;
                    currentSum = 0;
                }
                currentSum += array[i];

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestStart = startIndex;
                    bestEnd = i;
                }
            }
            for (int i = bestStart; i <= bestEnd; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
