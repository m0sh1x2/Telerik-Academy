using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer A (0 <= a <= 500) = ");
            int numA = int.Parse(Console.ReadLine());
            Console.Write("Enter a floating-point B = ");
            float numB = float.Parse(Console.ReadLine());
            Console.Write("Enter a floating-point C = ");
            float numC = float.Parse(Console.ReadLine());

            string numAHex = numA.ToString("X");
            string numAbin = Convert.ToString(numA, 2).PadLeft(10, '0');

            Console.WriteLine();
            Console.WriteLine("|{0,-10}|{1,0}|{2,10}|{3,-10}|", numAHex, numAbin, Math.Round(numB, 2), Math.Round(numC, 3));
        }
    }
}
