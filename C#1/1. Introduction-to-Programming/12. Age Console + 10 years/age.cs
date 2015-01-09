using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Age_Console___10_years
{
    class age
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age:");
            string age = Console.ReadLine();
            int myage = int.Parse(age);
            myage = myage + 10;
            Console.WriteLine("Your age after 10 years will be : " + myage );
        
        }
    }
}
