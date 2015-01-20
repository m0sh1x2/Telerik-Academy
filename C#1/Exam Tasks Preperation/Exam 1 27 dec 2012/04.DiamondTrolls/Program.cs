using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DiamondTrolls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n * 2 + 1;
            int height = (6 + ((n - 3) / 2) * 3);
            int[,] matrix = new int[width, height];

            //solution

            int counter;


                counter = n / 2 + 1;

            
            int secondCounter = 0;
            int thirdCOunter = 0;
            // print top
            for (int i = 0; i < n / 2 + 1; i++)
            {

                Console.Write(new string('.', counter));
                if (i == 0)
                {
                    if (n%2==0)
                    {
                        Console.Write(new string('*', n-1));
                    }
                    else
                    {
                        Console.Write(new string('*', n));
                    }
                    
                }
                if (secondCounter == 0)
                {
                    if (n%2==0)
                    {
                        secondCounter = n / 2 - 1;
                        thirdCOunter = n / 2 - 1;
                    }
                    else
                    {
                        secondCounter = n / 2;
                        thirdCOunter = n / 2;
                    }
                    
                }
                else
                {
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', secondCounter));
                    secondCounter++;
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', thirdCOunter));
                    thirdCOunter++;
                    Console.Write(new string('*', 1));

                }
                Console.Write(new string('.', counter));

                counter--;
                
                Console.WriteLine();

            }
            Console.WriteLine(new string('*', width));

            // print bottom

            int bottomCounter = 1;
            int bottomCounterCenter = n - 2;

            for (int i = 0; i < n; i++)
            {

                Console.Write(new string('.', bottomCounter));
                Console.Write(new string('*', 1));
                
                if (!(bottomCounterCenter < 0))
                {
                    Console.Write(new string('.', bottomCounterCenter));
                    
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', bottomCounterCenter));
                    Console.Write(new string('*', 1));
                    bottomCounterCenter--;
                    
                }
                Console.Write(new string('.', bottomCounter));

                
                bottomCounter++;


                Console.WriteLine();
            }





            /*
            //print

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (matrix[i,j] == 0)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
             * */
        }
    }
}
