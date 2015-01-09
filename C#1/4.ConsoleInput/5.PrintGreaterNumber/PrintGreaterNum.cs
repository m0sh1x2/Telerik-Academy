using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.PrintGreaterNumber
{
    class PrintGreaterNum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number : ");
            string Num1 = Console.ReadLine();
            int Num1Int = int.Parse(Num1);

            Console.Write("Enter second number : ");
            string Num2 = Console.ReadLine();
            int Num2Int = int.Parse(Num2);

            bool check1 = (Num1Int > Num2Int);
            Console.WriteLine("{0} : Num1 > Num2",check1);

            bool check2 = (Num1Int < Num2Int);
            Console.WriteLine("{0} : Num1 < Num2", check2);

            bool check3 = (Num1Int == Num2Int);
            Console.WriteLine("{0} : Num1 = Num2", check3);

           
           

    
        }
    }
}
