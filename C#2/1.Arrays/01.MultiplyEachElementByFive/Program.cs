using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MultiplyEachElementByFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.WriteLine("Multiplied : {0} ---> {1}", array[i], array[i] * 5);
            }
        }
    }
}
