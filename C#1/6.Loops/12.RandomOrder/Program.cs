using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RandomOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Random random = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i;
            }
            array = shuffle(array);

            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            


        }
        public static int[] shuffle(int[] array)
        {
            Random rand = new Random();
            for (int i = array.Length; i > 0; i--)
			{
			    int j = rand.Next(i);
                int k = array[j];
                array[j] = array[i-1];
                array[i-1] = k;
			}
            return array;
        }
    }
}
