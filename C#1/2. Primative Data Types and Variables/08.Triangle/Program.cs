using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        char copy = '\u00A9';
        StringBuilder main = new StringBuilder();
        int counter = 3;
        int triCounter = 1;


        Console.Write(new string(' ',counter));
        Console.Write(new string(copy,triCounter));
        Console.WriteLine(new string(' ', counter));
        counter--;
        triCounter++;
        Console.Write(new string(' ', counter));
        Console.Write(new string(copy, 1));
        Console.Write(new string(' ', 1));
        Console.Write(new string(copy, 1));
        Console.WriteLine(new string(' ', counter));
        counter--;
        triCounter++;
        Console.Write(new string(' ', counter));
        Console.Write(new string(copy, 1));
        Console.Write(new string(' ', 3));
        Console.Write(new string(copy, 1));
        Console.WriteLine(new string(' ', counter));
        Console.WriteLine(new string(copy, 7));


    }
}
