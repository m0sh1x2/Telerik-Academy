using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.XExpression
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] matrix = new int[8];
            //input
            for (int i = 0; i < 8; i++)
            {
                matrix[i] = int.Parse(Console.ReadLine());
            }
            //solution


            for (int i = 0; i < 8; i++)
            {
                for (int line = 7; line > 0; line--)
                {
                    for (int position = 0; position < 8; position++)
                    {
                        if ((matrix[line] >> position & 1) == 0 && (matrix[line - 1] >> position & 1) == 1)
                        {
                            matrix[line] |= (1 << position);
                            matrix[line - 1] ^= (1 << position);
                        }
                    }
                }
            }
            //output

            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }

            /*
            string input = Console.ReadLine();
            double result = 0;



            for (int i = 0; i < input.Length; i++)
            {
                double firstNumber = 0;
                double secondNumber = 0;

                if (input[i] == '(')
                {
                    
                }
                switch (input[i])
                {
                    case '+':
                        firstNumber = double.Parse(Convert.ToString(input[i - 1]));
                        secondNumber = double.Parse(Convert.ToString(input[i + 1]));
                        result += firstNumber + secondNumber;
                        break;
                    case '-':
                        firstNumber = double.Parse(Convert.ToString(input[i - 1]));
                        secondNumber = double.Parse(Convert.ToString(input[i + 1]));
                        Console.WriteLine(firstNumber);
                        Console.WriteLine(secondNumber);
                        result += firstNumber - secondNumber;
                        break;
                    case '*':
                        firstNumber = double.Parse(Convert.ToString(input[i - 1]));
                        secondNumber = double.Parse(Convert.ToString(input[i + 1]));
                        result += firstNumber * secondNumber;
                        break;
                    case '/':
                        firstNumber = double.Parse(Convert.ToString(input[i - 1]));
                        secondNumber = double.Parse(Convert.ToString(input[i + 1]));
                        result += firstNumber / secondNumber;
                        break;
                }
            }
            Console.WriteLine(result);
            */
        }
    }
}
