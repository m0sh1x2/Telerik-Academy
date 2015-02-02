using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BullsAndCows
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());

            for (int i = 1000; i <= 9999; i++)
            {

                int currentBulls = 0;
                int currentCows = 0;

                int currentD = i % 10;
                i /= 10;
                int currentC = i % 10;
                i /= 10;
                int currentB = i % 10;
                i /= 10;
                int currentA = i % 10;



                int tempNumber = number;
                int numberD = i % 10;
                number /= 10;
                int numberC = i % 10;
                number /= 10;
                int numberB = i % 10;
                number /= 10;
                int numberA = i % 10;

                if (currentA == numberA)
                {
                    bulls++;
                    currentA = -1;
                    numberA = -2;
                }

                if (currentB == numberB)
                {
                    bulls++;
                    currentB = -1;
                    numberB = -2;
                }

                if (currentC == numberC)
                {
                    bulls++;
                    currentC = -1;
                    numberC = -2;
                }

                if (currentD == numberD)
                {
                    bulls++;
                    currentD = -1;
                    numberD = -2;
                }


                //check for bulls

                if (currentBulls == bulls)
                {

                    Console.Write("{0} ", i);
                }
                currentBulls = 0;
                currentCows = 0;
            }


        }
    }
}
