using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exam_Tasks
{
    class NextDate
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            
            DateTime date = new DateTime(year,month,day).AddDays(1);

            Console.WriteLine(date.ToString("d.M.yyyy",ci));

        }
    }
}
