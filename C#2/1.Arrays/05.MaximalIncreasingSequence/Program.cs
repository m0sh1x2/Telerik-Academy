using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaximalIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 2, 3, 4, 2, 2, 4 };


            int countSeq = 0;
            int maxSeq = 0;
            int element = 0;


            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] + 1 == array[i + 1])
                {
                    countSeq++;
                }
                if (array[i] + 1 != array[i + 1])
                {

                    countSeq = 0;
                }
                if (maxSeq < countSeq)
                {
                    maxSeq = countSeq;
                    element = array[i];
                }

            }
            for (int i = maxSeq; i >= 0; i--)
            {
                Console.Write(" " + element--);
            }
            Console.WriteLine();
        }
    }
}
