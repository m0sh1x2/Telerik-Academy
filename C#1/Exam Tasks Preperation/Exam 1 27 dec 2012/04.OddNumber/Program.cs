using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            BigInteger[] numbers = new BigInteger[n];

            //Get the numbers
            for (int i = 0; i < n; i++)
            {
                numbers[i] = BigInteger.Parse(Console.ReadLine());
            }


            /*
             * This solution times out but it works 60/100
             * 
            BigInteger bestNum = 0;
            BigInteger bestNumCounter = 0;
            BigInteger counter = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                        bestNum = numbers[i];
                    }
                }
                if (counter % 2 !=0)
                {
                    Console.WriteLine(bestNum);
                    break;
                }
                counter = 0;
            }
            */
            var groups = numbers.GroupBy(v => v);
            foreach (var group in groups)
                if (group.Count() % 2 != 0)
                {
                    Console.WriteLine(group.Key);
                }
                


            Console.WriteLine();
        }
    }
}
