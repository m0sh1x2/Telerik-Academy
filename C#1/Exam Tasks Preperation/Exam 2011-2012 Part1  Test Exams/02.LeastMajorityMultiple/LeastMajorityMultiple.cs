using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LeastMajorityMultiple
{
    class LeastMajorityMultiple
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }



            int result = 0;

            for (int i = 1; true; i++)
            {
                int counter = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i % numbers[j] == 0)
                    {
                        counter++;
                    }
                }
                if (counter >= 3)
                {
                    Console.WriteLine(i);
                    break;
                }
                
            }

            

        }
    }
}
