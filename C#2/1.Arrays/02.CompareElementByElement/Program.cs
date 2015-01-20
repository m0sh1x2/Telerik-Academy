using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompareElementByElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array1 size :");
            int firstArraySize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array2 size: ");
            int secondtArraySize = int.Parse(Console.ReadLine());
            bool compare = true;

            if (firstArraySize == secondtArraySize)
            {
                int[] firstArray = new int[firstArraySize];
                for (int i = 0; i < firstArraySize; i++)
                {
                    Console.WriteLine("Enter array1[{0}] :", i);
                    firstArray[i] = int.Parse(Console.ReadLine());
                }


                int[] secondArray = new int[secondtArraySize];
                for (int i = 0; i < secondtArraySize; i++)
                {
                    Console.WriteLine("Enter array2[{0}] :", i);
                    secondArray[i] = int.Parse(Console.ReadLine());
                }


                for (int i = 0; i < firstArraySize; i++)
                {
                    if (firstArray[i] == secondArray[i])
                    {

                        compare = true;
                    }
                    else
                    {
                        compare = false;
                        break;
                    }
                }
            }

            if (!compare)
            {
                Console.WriteLine("Arrays are not identical !");
            }
            else
            {
                Console.WriteLine("Arrays are identical ! ");
            }
        }
    }
}
