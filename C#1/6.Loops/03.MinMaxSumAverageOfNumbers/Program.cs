using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxSumAverageOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            double  number1, number2, number3;
            double min = 0, max = 0, sum = 0,avg= 0;


            int amount = int.Parse(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {
                    number1 = double.Parse(Console.ReadLine());
                    sum += number1;
                    if (number1 > max)
                    {
                        max = number1;
                    }
                    if (number1 < max)
                    {
                        min = number1;
                    }
                    
            }



            avg = sum / amount;
            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0}", Math.Round(avg, 2));
        }

    }
}
