using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPVariables
{
    class Program
    {
        public static string ReadInput()
        {
            string currentLine = Console.ReadLine();
            StringBuilder phpCode = new StringBuilder();

            while (currentLine != "?>")
            {
                phpCode.AppendLine(currentLine);
                currentLine = Console.ReadLine().Trim();
            }

            string result = phpCode.ToString();
            return result;
        }

        public static bool IsValidVaraibleSymbom(char symbol)
        {
            if (char.IsLetterOrDigit(symbol) || symbol == '_')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static HashSet<string> ExtractWords(string input)
        {

            HashSet<string> allVariables = new HashSet<string>();



            bool inOneLineComment = false;
            bool inMultyLineComment = false;
            bool inSingleQuiteString = false;
            bool inDoubleQuiteString = false;
            bool inVaraible = false;

            var currentVariable = new StringBuilder();

            for (int i = 0; i < inputCode.Length; i++)
            {
                char currentSymbol = inputCode[i];

                // one line comment

                if (inOneLineComment)
                {
                    if (currentSymbol == '\n')
                    {
                        // one line comment ends here
                        inOneLineComment = false;
                        continue;
                    }
                    else
                    {
                        // still in one line comment
                        continue;
                    }
                }

                // multy line comment
                if (inMultyLineComment)
                {
                    if (currentSymbol == '*' && i + 1 < inputCode.Length && inputCode[i + 1] == '/')
                    {
                        inMultyLineComment = false;
                        i++; //nex symbol is checked we do not need it
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                }
                // variable
                if (inVaraible)
                {
                    if (IsValidVaraibleSymbom(currentSymbol))
                    {
                        currentVariable.Append(currentSymbol);
                        continue;
                    }
                    else
                    {
                        if (currentVariable.Length > 0)
                        {
                            allVariables.Add(currentVariable.ToString());
                        }

                        currentVariable.Clear();
                        inVaraible = false;
                        
                    }
                }

                // single quite string
                if (inSingleQuiteString)
                {
                    if (currentSymbol == '\'')
                    {
                        inSingleQuiteString = false;
                        continue;
                    }

                }

                // double quote string
                if (inDoubleQuiteString)
                {
                    if (currentSymbol == '\"')
                    {
                        inDoubleQuiteString = false;
                        continue;
                    }

                }

                if (!inSingleQuiteString && !inDoubleQuiteString)
                {

                    // starting one line comment with #
                    if (currentSymbol == '#')
                    {
                        inOneLineComment = true;
                        continue;
                    }

                    // starting one line comment with //
                    if (currentSymbol == '/' && i + 1 < inputCode.Length && inputCode[i + 1] == '/')
                    {
                        inOneLineComment = true;
                        i++;
                        continue;
                    }


                    //starting multi line comment

                    if (currentSymbol == '/' && i + 1 < inputCode.Length && inputCode[i + 1] == '*')
                    {
                        inMultyLineComment = true;
                        i++;
                        continue;
                    }
                }
                else
                {
                    // we are in string and next symbol must be escaped
                    if (currentSymbol == '\\')
                    {
                        i++;
                        continue;
                    }
                }
                // wea re stargin single quite string
                if (currentSymbol == '\'')
                {
                    inSingleQuiteString = true;
                    continue;
                }

                // we are starting double quite string
                if (currentSymbol == '\"')
                {
                    inDoubleQuiteString = true;
                    continue;
                }
                // if we areached we may be in variable
                if (currentSymbol == '$')
                {
                    inVaraible = true;
                    continue;
                }


            }

            return allVariables;
        }
        public static void PrintResult(HashSet<string> result)
        {
            Console.WriteLine(result.Count);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static string inputCode;
        static void Main(string[] args)
        {
            inputCode = ReadInput();
            var result = ExtractWords(inputCode);

            PrintResult(result);

        }


    }
}
