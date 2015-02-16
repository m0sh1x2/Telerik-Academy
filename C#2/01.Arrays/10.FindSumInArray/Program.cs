using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FindSumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 3, 1, 4, 2, 5, 8 };//int.Parse(Console.ReadLine());
            int S = 11; //int.Parse(Console.ReadLine());

            int sum = 0,
                startIndex = 0,
                endIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    sum += array[j];
                    if (sum > S)
                    {
                        sum = 0;
                    }
                    if (sum == S)
                    {
                        startIndex = i;
                        endIndex = j;
                        break;
                    }
                }
                if (sum == S)
                {
                    break;
                }
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
