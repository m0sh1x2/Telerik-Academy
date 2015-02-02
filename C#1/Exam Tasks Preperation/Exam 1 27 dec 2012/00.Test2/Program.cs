using System;


    class Program
    {
        static void Main()
        {
            Console.Write("Enter a valid card(2-A)");
            string inputCard = Console.ReadLine();
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            bool isInArray = false;


            // Начин 1
            foreach (var item in cards)
            {
                if (inputCard == item)
                {
                    isInArray = true;
                }
            }

            // Начин 2
            /*
            for (int i = 0; i < cards.Length; i++)
            {
                if (inputCard == cards[i])
                {
                    isInArray = true;
                }
            }
            */


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

