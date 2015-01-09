using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToN
{
    class OneToN
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            string x = Console.ReadLine();
            int intX = int.Parse(x);
            intX++;
            for (int i = 1; i < intX; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
