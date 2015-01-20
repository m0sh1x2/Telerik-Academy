using System;

class Program
{
    static void Main()
    {

        long inputNumber = long.Parse(Console.ReadLine());
        if (inputNumber < 0)
        {
            inputNumber = -inputNumber;
        }
        int oddDigits = 0;
        int evenDigits = 0;

        while (inputNumber > 0)
        {
            byte digit = (byte)(inputNumber % 10);
            if (digit % 2 == 0)
            {
                evenDigits += digit;
            }
            else
            {
                oddDigits += digit;
            }
            inputNumber /= 10;
        }

        if (oddDigits > evenDigits)
        {
            Console.WriteLine("left {0}",oddDigits);
        }
        else if (evenDigits > oddDigits)
        {
            Console.WriteLine("right {0}",evenDigits);
        }
        else if (evenDigits == oddDigits)
        {
            Console.WriteLine("straight {0}",oddDigits);
        }

    }
}

