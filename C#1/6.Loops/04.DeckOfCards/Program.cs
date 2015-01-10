using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string[] suits = new string[] { "hearts", "spades", "diamonds", "clubs" };
            string[] ranks = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            for (int card = 0; card < 13; card++)
            {
                for (int suit = 0; suit < 4; suit++)
                {
                    Console.Write("{0} of {1}, ",ranks[card],suits[suit]);
                    sum++;
                }
                Console.WriteLine();
            }
            
        }
    }
}
