using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alphabeth = new string[26];
            for (int i = 0; i < 26; i++)
            {
                alphabeth[i] = Convert.ToChar(i + 65).ToString();
            }
            string word = Console.ReadLine().ToUpper();
            

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabeth.Length; j++)
                {
                    string firstLetter = alphabeth[j].ToString();
                    string secondLetter = word[i].ToString();
                    if (firstLetter == secondLetter)
                    {
                        Console.Write(j + " ");

                    }
                }
            }



            Console.WriteLine();
        }
    }
}
