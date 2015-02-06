using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaximalKSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K : ");
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int a = 0; a < array.Length; a++)
            {
                Console.WriteLine("Enter {0} element : ", a);
                array[a] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int maxKsum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == k)
                {
                    sum += array[i];
                }
                if (array[i] != k)
                {
                    sum = 0;
                }
                if (sum > maxKsum)
                {
                    maxKsum = sum;
                }
            }

            Console.WriteLine(maxKsum);
        }
    }
}
