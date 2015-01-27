using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _05.GameOfPage
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            int[,] page = new int[16, 16];
            double price = 1.79;
            double paypal = 0.0;

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < 16; i++)
            {
                string binaryInput = Console.ReadLine();

                for (int j = 0; j < 16; j++)
                {
                    page[i, j] = int.Parse(binaryInput[j].ToString());
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "what is")
                {
                    int row = int.Parse(Console.ReadLine());
                    int col = int.Parse(Console.ReadLine());

                    if (row == 0 && col <= 15)
                    {
                        if (
                            //middle
                            page[row, col] == 1 &&
                            page[row, col + 1] == 1 &&
                            page[row, col - 1] == 1)
                        {
                            result.AppendLine("broken cookie");
                        }
                    }
                    else if (row == 0 && col == 0)
                    {
                        if (
                            //part of middle
                            page[row, col] == 1 &&
                            page[row, col - 1] == 1)
                        {
                            result.AppendLine("broken cookie");
                        }
                    }
                    else
                    {
                        if (
                            //middle
                            page[row, col] == 1 &&
                            page[row, col + 1] == 1 &&
                            page[row, col - 1] == 1 &&
                            //top
                            page[row + 1, col] == 1 &&
                            page[row + 1, col - 1] == 1 &&
                            page[row + 1, col + 1] == 1 &&
                            //bottom
                            page[row - 1, col - 1] == 1 &&
                            page[row - 1, col] == 1 &&
                            page[row - 1, col + 1] == 1)
                        {
                            result.AppendLine("cookie");
                        }
                        else if (page[row, col] == 1)
                        {
                            result.AppendLine("cookie crumb");
                        }
                        else
                        {
                            //If there is nothing well there is nothing :D
                            //Console.WriteLine("page");
                        }
                    }




                }
                else if (input == "buy")
                {
                    int row = int.Parse(Console.ReadLine());
                    int col = int.Parse(Console.ReadLine());
                    if (
                        //middle
                            page[row, col] == 1 &&
                            page[row, col + 1] == 1 &&
                            page[row, col - 1] == 1 &&
                        //top
                            page[row + 1, col] == 1 &&
                            page[row + 1, col - 1] == 1 &&
                            page[row + 1, col + 1] == 1 &&
                        //bottom
                            page[row - 1, col - 1] == 1 &&
                            page[row - 1, col] == 1 &&
                            page[row - 1, col + 1] == 1)
                    {

                        //middle
                        page[row, col] = 0;
                        page[row, col + 1] = 0;
                        page[row, col - 1] = 0;
                        //top
                        page[row + 1, col] = 1;
                        page[row + 1, col - 1] = 0;
                        page[row + 1, col + 1] = 0;
                        //bottom
                        page[row - 1, col - 1] = 0;
                        page[row - 1, col] = 0;
                        page[row - 1, col + 0] = 0;
                        result.AppendLine("smile");
                        paypal += price;

                    }
                    else if (page[row, col] == 1)
                    {
                        result.AppendLine("page");
                    }
                    else
                    {
                        //If there is nothing well there is nothing :D
                        //Console.WriteLine("page");
                    }

                }
                else if (input == "paypal")
                {
                    result.AppendLine(paypal.ToString());
                    break;
                }
                else
                {
                    //result.Append("smile");
                }
            }

            Console.WriteLine(result);

        }
    }
}
