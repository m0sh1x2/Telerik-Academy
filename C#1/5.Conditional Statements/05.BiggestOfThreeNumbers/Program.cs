using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace _3.BiggestOfThree
{
    class biggest
    {
        
        static double theBiggest(double first, double second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            double biggestNum = 0;

            biggestNum = theBiggest(firstNum, secondNum);
            biggestNum = theBiggest(biggestNum, thirdNum);

            Console.WriteLine("Biggest num is {0}", biggestNum);

        }
    }
}
