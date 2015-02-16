using System;

class EnglishDigit
{
    static void Main()
    {
        //•	Write a method that returns the last digit of given integer as an English word.
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(LastDigitWord(number));
    }

    public static string LastDigitWord(int number)
    {

        number %= 10;


        switch (number)
        {
            case 0:
                return "zero";
                break;
            case 1:
                return "one";
                break;
            case 2:
                return "two";
                break;
            case 3:
                return "three";
                break;
            case 4:
                return "four";
                break;
            case 5:
                return "five";
                break;
            case 6:
                return "six";
                break;
            case 7:
                return "seven";
                break;
            case 8:
                return "eight";
                break;
            case 9:
                return "nine";
                break;
        }
        return "NAN";
    }
}

