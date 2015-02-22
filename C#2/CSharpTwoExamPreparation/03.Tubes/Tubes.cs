using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Tubes
{
    class Tubes
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long m = long.Parse(Console.ReadLine());

            var tubes = new long[n];


            long maxTube = 0;

            for (long i = 0; i < n; i++)
            {
                tubes[i] = long.Parse(Console.ReadLine());
                if (tubes[i] > maxTube)
                {
                    maxTube = tubes[i];
                }
            }
            Array.Sort(tubes);

            long left = 1;
            long right = maxTube;
            long middle;
            long finalResult = -1;

            while (left <= right)
            {
                middle = (left + right) / 2;
                long eventual = 0;
                for (long j = 0; j < tubes.Length; j++)
                {
                    eventual = eventual + tubes[j] / middle;
                }
                if (eventual < m)
                {
                    right = middle - 1;
                }
                else if (eventual >= m)
                {
                    left = middle + 1;
                    finalResult = middle;
                }

            }


            Console.WriteLine(finalResult);
            /* slow algorithm
            for (long i = maxTube; i >= 1; i--)
            {
                long eventual = 0;

                for (long j = 0; j < tubes.Length; j++)
                {
                    eventual += tubes[j] / i;
                }

                if (eventual >= m )
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            */


        }
        public static long binarySearch(long[] array, long number)
        {
            long start = 0;
            long end = array.Length;
            long mid;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (array[mid] == number)
                {
                    return mid;
                }
                else if (number < mid)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return -1;
        }
    }
}
