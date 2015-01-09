//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class Program
{
    static void Main(string[] args)
    {
        /////////////// part 1 \\\\\\\\\\\\\

        int number = int.Parse(Console.ReadLine());
        int position1 = 3;
        int position2 = 24;

        int mask1 = 1 << position1;
        int mask2 = 1 << position2;
        Console.WriteLine("Number: {0}",number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(mask1,2).PadLeft(32,'0'));
        Console.WriteLine(Convert.ToString(mask2, 2).PadLeft(32, '0'));


        int ex1 = ~mask1 & number;
        int ex2 = ~mask2 | number;
        ex2= ~ex2;
        number = ex1 & number;
        number = ex2 | number;
        Console.WriteLine("Number: {0}", number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("----------------");
        int save = number;

        /////////////// part 2 \\\\\\\\\\\\\

        int position3 = 4;
        int position4 = 25;
        int mask3 = 1 << position3;
        int mask4 = 1 << position4;
        int ex3 = ~mask3 & number;
        int ex4 = ~mask4 | number;
        ex4 = ~ex4;
        number = ex3 & number;
        number = ex4 | number;

        Console.WriteLine("Number: {0}", number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));


        ////////////// part 3 \\\\\\\\\\\\\

        int position5 = 5;
        int position6 = 26;
        int mask5 = 1 << position5;
        int mask6 = 1 << position6;
        int ex5 = ~mask5 & number;
        int ex6 = ~mask6 | number;
        ex6 = ~ex6;
        number = ex5 & number;
        number = ex6 | number;

        Console.WriteLine("Number: {0}", number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}