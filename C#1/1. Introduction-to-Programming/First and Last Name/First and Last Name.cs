using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_and_Last_Name
{
    class FirstNameAndLastName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name : ");
            string first_name = Console.ReadLine();
            Console.WriteLine("Enter your second name : ");
            string second_name = Console.ReadLine();
            Console.WriteLine("Welcome : " + first_name + " " + second_name);
        }
    }
}
