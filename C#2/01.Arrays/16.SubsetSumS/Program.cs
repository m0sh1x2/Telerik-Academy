using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.SubsetSumS
{
    class Program
    {
        static void Main(string[] args)
        {

            //2, 1, 2, 4, 3, 5, 2, 6
            Console.WriteLine("Enter the arrays elements separated by comma : ");
            string[] array = Console.ReadLine().Split(',');

            int[] elements = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                elements[i] = int.Parse(array[i]);
            }
            Console.WriteLine("Enter the sum that you need to find : ");

            int sum = int.Parse(Console.ReadLine());
            int length = elements.Length;
            int counter = 0;
            string subset = "";
            int numberOfElements = elements.Length;

            int maxSubsets = (int)Math.Pow(2, numberOfElements) - 1;
            for (int i = 1; i <= maxSubsets; i++)
            {
                subset = "";
                long checkingSum = 0;
                for (int j = 0; j <= numberOfElements; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = nAndMask >> j;
                    if (bit == 1)
                    {
                        checkingSum = checkingSum + elements[j];
                        subset = subset + " " + elements[j];
                    }
                }
                if (checkingSum == sum)
                {   
                    counter++;
                    Console.WriteLine("Subset of {0} : {1} ", sum, subset);
                }
            }
            Console.WriteLine(counter);

        }
    }
}
