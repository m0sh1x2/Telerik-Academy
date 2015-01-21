using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Eggcelent
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 2 * n;
            int width = 3 * n - 1;

            //width of drawing area 3*n+1
            //size of top and bottom is n-1

            //draw top

            int[,] matrix = new int[height, width];


            int countDots = n - 1;
            int innerDOts = n + 1;

            bool draw = false;

            bool moreInner = true;
            for (int row = 0; row < n; row++)
            {
                if (row == 0)
                {
                    Console.Write(new string('.', n + 1));
                    Console.Write(new string('*', n - 1));
                    Console.Write(new string('.', n + 1));
                }
                else
                {

                    if (countDots < 0)
                    {
                        countDots = 1;
                    }
                    if (innerDOts >= width)
                    {
                        innerDOts = width - 2;
                        moreInner = false;
                    }
                    if (row != n - 1)
                    {
                        Console.Write(new string('.', countDots));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('.', innerDOts));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('.', countDots));
                    }
                    else
                    {
                        Console.Write(new string('.', countDots));
                        Console.Write(new string('*', 1));

                        for (int i = 0; i < innerDOts; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write(new string('@', 1));
                            }
                            else
                            {
                                Console.Write(new string('.', 1));
                            }
                        }
                        Console.Write(new string('*', 1));
                        Console.Write(new string('.', countDots));
                    }
                    if (moreInner)
                    {
                        innerDOts += 4;
                    }
                    countDots -= 2;
                }

                Console.WriteLine();
            }

            // draw bottom


            countDots = 1;
            bool continueDots = false;
            bool lessInner = false;
            int countInner = 0;
            int bottomOuter = 0;


            for (int row = n; row > 0; row--)
            {
                if (row == n)
                {
                    Console.Write(new string('.', 1));
                    Console.Write(new string('*', 1));
                    for (int i = 0; i < width - 2; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(new string('.', 1));
                        }
                        else
                        {
                            Console.Write(new string('@', 1));
                        }

                    }
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', 1));
                }
                else
                {
                    // the reverse part
                    if (row <= 1)
                    {
                        Console.Write(new string('.', n + 1));
                        Console.Write(new string('*', n - 1));
                        Console.Write(new string('.', n + 1));
                    }
                    else
                    {
                        Console.Write(new string('.', countDots));
                        Console.Write(new string('*', 1));

                        if (row == n / 2 + 1)
                        {
                            continueDots = true;
                            innerDOts += 4;
                        }
                        if (continueDots)
                        {
                            countDots += 2;
                            innerDOts -= 4;


                        }


                        Console.Write(new string('.', innerDOts));
                        Console.Write(new string('*', 1));

                        if (row <= n / 2 + 1)
                        {
                            bottomOuter += 2;
                            Console.Write(new string('.', bottomOuter - 1));
                        }
                        else
                        {
                            Console.Write(new string('.', 1));
                        }

                    }
                }
                Console.WriteLine();
            }



        }
    }
}
