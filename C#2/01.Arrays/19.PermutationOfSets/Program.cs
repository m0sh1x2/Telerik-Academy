using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    class Permutation
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            Perm(arr, 0, arr.Length - 1);

        }
        private static void Perm(int[] arr, int k, int n)
        {
            if (k == n)
            {
                Print(arr);
            }
            else
            {
                for (int i = k; i <= n; i++)
                {
                    SwapElements(arr, k, i);
                    Perm(arr, k + 1, n);
                    SwapElements(arr, k, i);
                }
            }

        }
        private static void SwapElements(int[] arr, int k, int i)
        {
            int t = arr[k];
            arr[k] = arr[i];
            arr[i] = t;
        }
        private static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }

}
