using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array : ");
            int n = int.Parse(Console.ReadLine());
            var array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter {0} element : ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter K :");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine(SortTheArray(array, k));

        }
        public static int SortTheArray(int[] array, int k)
        {
            Array.Sort(array);
            while (Array.BinarySearch(array, k) < 0)
            {
                k--;
            }
            return k;
        }
    }
}
