using System;


class OnesAndZeroes
{
    static void Main()
    {


        bool one = true;
        int number = int.Parse(Console.ReadLine());

        //number & (1<<p) 



        for (int row = 0; row < 5; row++)
        {

            for (int col = 15; col >= 0; col--)
            {

                if (col != 15)
                {
                    Console.Write(".");
                }

                //Check position
                one = Convert.ToBoolean(number & (1 << col));


                if (one)
                {
                    switch (row)
                    {
                        case 0:
                            Console.Write(".#.");
                            break;
                        case 1:
                            Console.Write("##.");
                            break;
                        case 2:
                            Console.Write(".#.");
                            break;
                        case 3:
                            Console.Write(".#.");
                            break;
                        case 4:
                            Console.Write("###");
                            break;
                    }
                }
                else
                {
                    switch (row)
                    {
                        case 0:
                            Console.Write("###");
                            break;
                        case 1:
                            Console.Write("#.#");
                            break;
                        case 2:
                            Console.Write("#.#");
                            break;
                        case 3:
                            Console.Write("#.#");
                            break;
                        case 4:
                            Console.Write("###");
                            break;
                    }
                }
            }
            Console.WriteLine();
        }

        // print the matrix;

        for (int i = 4; i >= 0; i--)
        {
            for (int j = 30; j >= 0; j--)
            {


            }

        }
    }
}

