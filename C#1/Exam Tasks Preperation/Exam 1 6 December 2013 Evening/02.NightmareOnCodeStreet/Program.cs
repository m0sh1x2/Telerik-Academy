using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NightmareOnCodeStreet
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().TrimStart(new Char[] { '0' }); ;
            long counter = 0, sum = 0;

            for (int i = 1; i < input.Length; i+=2)
            {
                //Check if it is a digit or you woun't get 100/100 
                if (char.IsDigit(input[i]))
                {

                    counter++;
                    sum += long.Parse(input[i].ToString());

                }
            }
            Console.WriteLine("{0} {1}", counter, sum);
        }
    }
}
