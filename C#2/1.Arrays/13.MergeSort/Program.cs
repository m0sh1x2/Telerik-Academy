using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 4, 3, 1, 2, 6 };
            MergeSort(array, 0, array.Length - 1);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        
        public static void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                {
                    temp[pos++] = numbers[left++];
                }
                else
                {
                    temp[pos++] = numbers[mid++];
                }
            }
            while (left <= eol)
            {
                temp[pos++] = numbers[left++];
            }
            while (mid <= right)
            {
                temp[pos++] = numbers[mid++];
            }
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        public static void MergeSort(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(numbers, left, mid);
                MergeSort(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
        }
    }
}
