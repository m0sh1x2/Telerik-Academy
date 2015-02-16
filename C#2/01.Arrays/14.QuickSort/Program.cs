using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 4, 3, 2, 1 };
            QuickSort(array, 0, array.Length - 1);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        public static void QuickSort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }
            // Recursive calls
            if (left < j)
            {
                QuickSort(elements, left, j);
            }
            if (i < right)
            {
                QuickSort(elements, i, right);
            }
        }
    }
}
