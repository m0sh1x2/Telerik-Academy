using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaximmalSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 1, 1,1,1,1, 2, 3, 3, 2, 2, 2, 1 };

            int length = 1;
            int bestlength = 0;
            int element = 0;

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


            for (int i = 0; i < bestlength; i++)
            {
                if (i == 0)
                {
                    Console.Write("{");
                }
                if (i < bestlength-1)
                {
                    Console.Write(element + ",");
                }
                else
                {
                    Console.Write(element+"}");
                }
                
            }
            Console.WriteLine();
        }
    }
}
