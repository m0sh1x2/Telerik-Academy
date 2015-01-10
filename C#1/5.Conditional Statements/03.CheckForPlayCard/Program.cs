using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CheckForPlayCard
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cards = new string[] {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
            string input = Console.ReadLine();
            bool continueBro = false;
            for (int i = 0,length = cards.Length; i < length; i++)
            {
                if (input == cards[i])
                {
                    Console.WriteLine("yes");
                    continueBro = true;
                }
            }
            if (!continueBro)
            {
                Console.WriteLine("no");
            }
        }
    }
}
