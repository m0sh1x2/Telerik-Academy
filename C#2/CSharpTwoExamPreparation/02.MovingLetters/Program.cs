using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MovingLetters
{
    class Program
    {
        static StringBuilder ExtractLetters(string[] words)
        {
            int maxWordLength = 0;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if (maxWordLength < currentWord.Length)
                {
                    maxWordLength = currentWord.Length;
                }
            }

            for (int i = 0; i < maxWordLength; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    string currentWord = words[j];

                    if (i < currentWord.Length)
                    {
                        int lastLetter = currentWord.Length - 1 - i;
                        result.Append(currentWord[lastLetter]);
                    }

                }
            }
            return result;
        }

        static string MoveLetters(StringBuilder strangePieceOfWords)
        {
            for (int i = 0; i < strangePieceOfWords.Length; i++)
            {
                char currentSymbol = strangePieceOfWords[i];
                int transition = char.ToLower(currentSymbol) + 1 - 97;

                
                strangePieceOfWords.Remove(i, 1);
                int nextPosition = (i + transition) % (strangePieceOfWords.Length + 1);
                strangePieceOfWords.Insert(nextPosition, currentSymbol);

            }


            return strangePieceOfWords.ToString();
        }

        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder strangeCombinationOfLetters = ExtractLetters(words);

            string finalResult = MoveLetters(strangeCombinationOfLetters);

            Console.WriteLine(finalResult);

        }
    }
}
