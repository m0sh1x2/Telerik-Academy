using System;

class Workdays
{
    static DateTime[] Holidays = {
                                   new DateTime(2015,01,01),
                                   new DateTime(2015,01,18),
                                   new DateTime(2015,01,28),
                                   new DateTime(2015,01,31)
                               };
    static void Main()
    {
        /*•	Write a method that calculates the number of workdays between today and given date, 
         * passed as parameter.
          •	Consider that workdays are all days from Monday to Friday except a fixed list of public 
         * holidays specified preliminary as array.*/
        var today = DateTime.Now;
        var future = new DateTime(2015,12,31);
        Console.WriteLine(WorkingDays(today, future));

    }
    static int WorkingDays(DateTime today, DateTime future)
    {
        int days = Math.Abs((today - future).Days);
        int counter = days;

        for (int i = 0; i < days; i++)
        {
            if (today.DayOfWeek == DayOfWeek.Sunday || today.DayOfWeek == DayOfWeek.Saturday)
            {
                counter--;
            }
            for (int j = 0; j < Holidays.Length; j++)
            {
                if (today.CompareTo(Holidays[j]) == 0)
                {
                    counter--;
                }
            }
        }

        return counter;
    }
}

