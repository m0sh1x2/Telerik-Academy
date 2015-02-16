using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 1, 1, 1, 1, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            int element = 0,
                length = 1,
                bestlength = 0;

            Array.Sort(array);


            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    length++;
                }
                if (array[i] != array[i + 1])
                {
                    length = 1;
                }
                if (length > bestlength)
                {
                    bestlength = length;
                    element = array[i];
                }
            }
            Console.WriteLine("{0} ({1}times)", element, bestlength);// 

        }
    }
}
