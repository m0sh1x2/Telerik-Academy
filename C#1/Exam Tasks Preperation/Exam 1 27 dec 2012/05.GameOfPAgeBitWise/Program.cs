using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GameOfPAgeBitWise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[16];
            string commandEnd = "paypal", commandBuy = "buy", commandWhatIs = "what is";

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == commandEnd)
                {
                    break;
                }
                int row = int.Parse(Console.ReadLine());
                int col = 15 - int.Parse(Console.ReadLine());

                int upperRow;
                int middleRow = 0;
                int lowerRow;

                switch (row)
                {
                    case 0: upperRow = 0; middleRow = numbers[0]; lowerRow = numbers[1]; break;
                    case 1: upperRow = numbers[0]; middleRow = numbers[1]; lowerRow = numbers[2]; break;
                    case 2: upperRow = numbers[1]; middleRow = numbers[2]; lowerRow = numbers[3]; break;
                    case 3: upperRow = numbers[2]; middleRow = numbers[3]; lowerRow = numbers[4]; break;
                    case 4: upperRow = numbers[3]; middleRow = numbers[4]; lowerRow = numbers[5]; break;
                    case 5: upperRow = numbers[4]; middleRow = numbers[5]; lowerRow = numbers[6]; break;
                    case 6: upperRow = numbers[5]; middleRow = numbers[6]; lowerRow = numbers[7]; break;
                    case 7: upperRow = numbers[6]; middleRow = numbers[7]; lowerRow = numbers[8]; break;
                    case 8: upperRow = numbers[7]; middleRow = numbers[8]; lowerRow = numbers[9]; break;
                    case 9: upperRow = numbers[8]; middleRow = numbers[9]; lowerRow = numbers[10]; break;
                    case 10: upperRow = numbers[9]; middleRow = numbers[10]; lowerRow = numbers[11]; break;
                    case 11: upperRow = numbers[10]; middleRow = numbers[11]; lowerRow = numbers[12]; break;
                    case 12: upperRow = numbers[11]; middleRow = numbers[12]; lowerRow = numbers[13]; break;
                    case 13: upperRow = numbers[12]; middleRow = numbers[13]; lowerRow = numbers[14]; break;
                    case 14: upperRow = numbers[13]; middleRow = numbers[14]; lowerRow = numbers[15]; break;
                    case 15: upperRow = numbers[14]; middleRow = numbers[15]; lowerRow = 0; break;
                }

                int cookieCenter = 1 << col;
                bool isCookieCrumb = (middleRow & cookieCenter) != 0;
                bool isBrokenCookie = (upperRow & (1 << (1<<(col+1)) !=0);
                    //upper row

                    //middle row

                    //lower row


                if (command == commandWhatIs)
                {

                }
                if (command == commandBuy)
                {

                }

            }
        }
    }
}
