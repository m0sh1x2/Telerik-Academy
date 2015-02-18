using System;
using System.Text;

class LeapYear
{
    static void Main()
    {
        //•	Write a program that reads a year from the console and checks whether it is a leap one.
        //•	Use System.DateTime.
        int year = int.Parse(Console.ReadLine());
        bool isLeapYear = DateTime.IsLeapYear(year);
        Console.WriteLine(isLeapYear);
        
    }
}

