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

        }
    }
}
