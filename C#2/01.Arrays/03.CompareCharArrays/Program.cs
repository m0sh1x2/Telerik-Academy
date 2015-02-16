using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = new char[] { 'a','b','c' };
            char[] arr2 = new char[] { 'a', 'b', 'c' };

            bool compare = false;
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        compare = true;
                    }
                    else
                    {
                        compare = false;
                        break;
                    }
                }
                if (compare)
                {
                    Console.WriteLine("Arrays are equal !");
                }
                else
                {
                    Console.WriteLine("Can't compare !");
                }
            }
            else
            {
                Console.WriteLine("Can't compare");
            }

        }
    }
}
