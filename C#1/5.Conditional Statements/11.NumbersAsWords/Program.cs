using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Convert
{
    public static void Digits(int number)
    {
        // from 0 to 9
        switch (number)
        {
            case 0:
                Console.Write(" Zero ");
                break;
            case 1:
                Console.Write(" One ");
                break;
            case 2:
                Console.Write(" Two ");
                break;
            case 3:
                Console.Write(" Three ");
                break;
            case 4:
                Console.Write(" Four ");
                break;
            case 5:
                Console.Write(" Five ");
                break;
            case 6:
                Console.Write(" Six ");
                break;
            case 7:
                Console.Write(" Seven ");
                break;
            case 8:
                Console.Write(" Eight ");
                break;
            case 9:
                Console.Write(" Nine ");
                break;
        }

    }

    // for 10-19
    public static void specialClasses(int number)
    {
        switch (number)
        {
            case 10:
                Console.Write(" Ten ");
                break;

            case 11:
                Console.Write(" Eleven ");
                break;

            case 12:
                Console.Write(" Twelve ");
                break;

            case 13:
                Console.Write(" Thirteen ");
                break;

            case 14:
                Console.Write(" Fourteen ");
                break;

            case 15:
                Console.Write(" Fifteen ");
                break;

            case 16:
                Console.Write(" Sixteen ");
                break;

            case 17:
                Console.Write(" Seventeen ");
                break;

            case 18:
                Console.Write(" Eighteen ");
                break;

            case 19:
                Console.Write(" Nineteen ");
                break;
        }
    }

    public static void tens(int number)
    {
        switch (number)
        {
            case 2:
                Console.Write(" Twenty ");
                break;
            case 3:
                Console.Write(" Thirty ");
                break;
            case 4:
                Console.Write(" Fourty ");
                break;
            case 5:
                Console.Write(" Fifty ");
                break;
            case 6:
                Console.Write(" Sixty ");
                break;
            case 7:
                Console.Write(" Seventy ");
                break;
            case 8:
                Console.Write(" Eighty ");
                break;
            case 9:
                Console.Write(" Ninety ");
                break;
        }
    }

    public static void hundreds(int number)
    {
        switch (number)
        {
            case 1:
                Console.Write(" One Hundred");
                break;
            case 2:
                Console.Write(" Two Hundred");
                break;
            case 3:
                Console.Write(" Three Hundred");
                break;
            case 4:
                Console.Write(" Four Hundred");
                break;
            case 5:
                Console.Write(" Five Hundred");
                break;
            case 6:
                Console.Write(" Six Hundred");
                break;
            case 7:
                Console.Write(" Seven Hundred");
                break;
            case 8:
                Console.Write(" Eight Hundred");
                break;
            case 9:
                Console.Write(" Nine Hundred");
                break;
        }
    }

    static void Main(string[] args)
    {
        int number, firstNum, secondNum, thirdNum;
        Console.Write("Enter number : ");
        int.TryParse(Console.ReadLine(), out number);

        while (number < 1 || number > 999)
        {
            Console.WriteLine("Enter number between 1 and 999 !");
            Console.Write("Enter number : ");
            int.TryParse(Console.ReadLine(), out number);

        }

        Console.Write("Answer : ");

        // 1 to 10
        if (number < 10)
        {
            Digits(number);
        }
        // 10 to 19
        else if (number >= 10 && number <= 19)
        {
            specialClasses(number);
        }
        // 20 to 100
        else if (number >= 20 && number <= 100)
        {
            firstNum = number / 10;
            secondNum = number % 10;
            if (secondNum == 0)
            {
                tens(firstNum);
            }
            else
            {
                tens(firstNum);
                Digits(secondNum);
            }
        }
        // 100 to 999
        else if (number >= 100 && number <= 999)
        {
            firstNum = number / 100;
            secondNum = (number / 10) % 10;
            thirdNum = number % 10;
            hundreds(firstNum);

            int specials = number % 100;
            int digits = number % 100; // checking for digits 1 to 9.
            if (digits > 0 && digits < 10)
            {
                Console.Write(" and ");
                Digits(digits);
            }
            if (specials >= 20)
            {
                specialClasses(specials);
            }
            int noZero = number % 100;
            if (noZero == 0)
            {
                hundreds(noZero);
            }
            else if (number > 20 && number < 1000)
            {
                tens(secondNum);
                int zeroChecker = number % 100;
                int otherZeroChecker = number % 10;

                if (otherZeroChecker != 0 && zeroChecker != 1 && zeroChecker != 2 && zeroChecker != 3
                    && zeroChecker != 4 && zeroChecker != 5 && zeroChecker != 6 && zeroChecker != 7 &&
                    zeroChecker != 9 && !(specials >= 10 && specials < 20))
                {
                    Digits(thirdNum);
                }
            }
        }

        Console.WriteLine();
    }
}


