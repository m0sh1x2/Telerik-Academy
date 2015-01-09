using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.NumbersBetween
{
    class NumBetween
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("How many numbers exist betwiin the two numbers that are devidable by 5");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Enter first positive number : ");
            string num1 = Console.ReadLine();
            int num1Int = int.Parse(num1);
            num1Int++;
            Console.Write("Enter second positive number : ");
            string num2 = Console.ReadLine();
            int num2Int = int.Parse(num2);
            num2Int++;

            List<int> list = new List<int>();

            for (int a = num1Int; a < num2Int; a++)
            {
                if (a % 5 == 0)
                {
                    list.Add(a);
                }
            }
            int[] terms = list.ToArray();

            int arrayLenght = terms.Length;
            Console.WriteLine("p({0},{1}) = {2}",--num1Int,--num2Int,arrayLenght);
        }
    }
}
