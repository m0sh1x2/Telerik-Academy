using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCombinations
{
    class ArrayCombinations
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());  //Input N
            int[] arr = new int[int.Parse(Console.ReadLine())]; //input K

            Combination(arr, n, 0, 0);
        }

        static void Check(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.WriteLine(arr[i] + 1);
                }
                else
                {
                    Console.Write(arr[i] + 1 + " ");
                }
            }
        }

        static void Combination(int[] arr, int n, int i, int next)
        {
            if (i == arr.Length)
            {
                Check(arr);
                return;
            }

            for (int j = next; j < n; j++)
            {
                arr[i] = j;

                Combination(arr, n, i + 1, j + 1);
            }
        }
    }
}