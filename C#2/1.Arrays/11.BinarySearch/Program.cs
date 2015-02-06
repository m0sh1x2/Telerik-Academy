using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 7, 13, 1337, 2015, 5, 114, 532131, -153151, 12412, 21421, -1337, 1337, 5, 69, 1, 5 };

            //Sort the array
            Array.Sort(array);
            /*
            int index = 0;
            foreach (var item in array)
            {
                Console.Write("{0} ",item);
                index++;
            }
            Console.WriteLine();
            */
            //return the position of the element
            Console.WriteLine(binarySearch(array, 13));


        }

        //Logic
        public static int binarySearch(int[] array, int number)
        {
            int start = 0;
            int end = array.Length;
            int mid;
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
