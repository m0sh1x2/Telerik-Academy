using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.XExpressionMe
{
    class Program
    {
        static void Main(string[] args)
        {

            string number = Console.ReadLine();
            decimal result = 0;
            decimal bracketResult = 0;
            bool inBracket = false;



            char currentSymbol = '+';
            char currentBracketSymbol = '+';


            foreach (char symbol in number)
            {

                if (symbol == '(')
                {
                    inBracket = true;
                    continue;
                }

                if (symbol == ')')
                {
                    inBracket = false;
                    switch (currentSymbol)
                    {
                        case '+': result += bracketResult; break;
                        case '-': result -= bracketResult; break;
                        case '*': result *= bracketResult; break;
                        case '/': result /= bracketResult; break;
                    }
                    bracketResult = 0;
                    currentBracketSymbol = '+';
                    
                }


                if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
                {
                    if (inBracket)
                    {
                        currentBracketSymbol = symbol;
                    }
                    else
                    {
                        currentSymbol = symbol;
                    }
                }
                if (symbol >= '0' && symbol <= '9')
                {
                    int currentNumber = symbol - '0';

                    if (inBracket)
                    {
                        switch (currentBracketSymbol)
                        {
                            case '+': bracketResult += currentNumber; break;
                            case '-': bracketResult -= currentNumber; break;
                            case '*': bracketResult *= currentNumber; break;
                            case '/': bracketResult /= currentNumber; break;
                        }
                    }
                    else
                    {
                        switch (currentSymbol)
                        {
                            case '+': result += currentNumber; break;
                            case '-': result -= currentNumber; break;
                            case '*': result *= currentNumber; break;
                            case '/': result /= currentNumber; break;
                        }
                    }
                }
            }
            Console.WriteLine("{0:F2}", result);
        }
    }
}
