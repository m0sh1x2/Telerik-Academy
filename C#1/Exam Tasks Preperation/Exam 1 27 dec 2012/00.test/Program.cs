using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a valid card(2-A)");
        string inputCard = Console.ReadLine();
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        bool isInArray = false;


        foreach (var item in cards)
        {
            if (inputCard == item)
            {
                isInArray = true;
            }
        }

        if (isInArray)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

    }
}

