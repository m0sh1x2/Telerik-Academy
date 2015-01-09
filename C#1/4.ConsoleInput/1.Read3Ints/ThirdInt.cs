using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Read3Ints
{
    class ThirdInt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Sum of 3 numbers");
            Console.WriteLine("----------------");
            Console.WriteLine();

            Console.Write("Enter First Num : ");
            string Int1 = Console.ReadLine();
            int number1 = int.Parse(Int1);
                //if(int.TryParse(Int1, out number1)){
                //    Console.WriteLine("Parsing sucess !");
                //}
                //else
                //{
                //    Console.WriteLine("Parsing FAILED");
                //}

            Console.Write("Enter Second Num : ");
            string Int2 = Console.ReadLine();
            int number2 = int.Parse(Int2);
                //if (int.TryParse(Int2, out number1))
                //{
                //    Console.WriteLine("Parsing sucess !");
                //}
                //else
                //{
                //    Console.WriteLine("Parsing FAILED");
                //}

            Console.Write("Enter Third Num : ");
            string Int3 = Console.ReadLine();
            int number3 = int.Parse(Int3);
                //if (int.TryParse(Int3, out number1))
                //{
                //    Console.WriteLine("Parsing sucess !");
                //}
                //else
                //{
                //    Console.WriteLine("Parsing FAILED");
                //}

            int sum = number1 + number2 + number3;
            Console.WriteLine("{0} + {1} + {2} = {3}", number1, number2, number3,sum);
        }
    }
}
