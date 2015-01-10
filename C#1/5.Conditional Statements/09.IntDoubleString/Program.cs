using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.WriteLine("Choose a type");
            Console.WriteLine("1 --> int, 2 --> double, 3--> string");
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine(choice + "*");
            }
            if (number == 2)
            {
                double choice = double.Parse(Console.ReadLine());
                choice += 1.0;

                Console.WriteLine(choice + "*");
            }
            if (number == 3)
            {
                string choice = Console.ReadLine();
                Console.WriteLine(choice + "*");
            }
        }
    }
}
