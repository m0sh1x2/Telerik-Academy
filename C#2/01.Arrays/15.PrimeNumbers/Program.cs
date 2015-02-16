using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] list = new int[n - 1];
            int counter = 2;
            for (int i = 0; i < list.Length; i++)
            {
                //generate the array
                list[i] = counter++;

            }
            int firstPosition = 0;
            int secondPosition = 1;
            int thirdPosition = 4;
            for (int i = 0; i < list.Length; i++)
            {
                //remove 2nd numbers
                if (i % 2 == 0 && i > 0)
                {
                    list[i] = 0;
                }
                if (list[i] % 3 == 0 && i > 1)
                {
                    list[i] = 0;
                }

                if (list[i] % 5 == 0 && i > 3)
                {
                    list[i] = 0;
                }

            }


            foreach (var item in list)
            {
                if (item == 0)
                {
                    //Console.Write("x");
                }
                else
                {
                    Console.Write(item + " ");
                }

            }
            Console.WriteLine();
        }
    }
}
