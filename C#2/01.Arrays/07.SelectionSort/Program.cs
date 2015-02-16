using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] { 1, 5, 4, 2, 2, 1, 0 };
            int i, j, min, temp;


            for (i = 0; i < array.Length - 1; i++)
            {
                min = i;

                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }


            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}
