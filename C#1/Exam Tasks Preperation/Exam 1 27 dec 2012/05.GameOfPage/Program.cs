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

            int[,] page = new int[18, 18];
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

                    //check for broken

                   


                }
                else if (input == "buy")
                {
                    int row = int.Parse(Console.ReadLine());
                    int col = int.Parse(Console.ReadLine());
                    

                }
                else if (input == "paypal")
                {
                    
                }
                else
                {
                    
                }
            }

            Console.WriteLine("{0:0.00}",result);

        }
    }
}
