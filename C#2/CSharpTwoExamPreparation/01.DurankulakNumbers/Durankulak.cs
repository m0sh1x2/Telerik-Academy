using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DurankulakNumbers
{
    class Durankulak
    {
        public static string[] digits = new string[168];
        static void Main(string[] args)
        {
            ulong result = 0;
            int nextDigit = -1;
            int counter = 0;

            //Fill the array
            FillTheArray(digits, ref nextDigit, ref counter);
            //Read the input
            string input = Console.ReadLine();

            //Make the calculations and find the numbers

            //count the digits
            string currentNumber = String.Empty;

            ulong countDigits = 0;
            for (int i = 0; i < input.Length; i++)
            {
                currentNumber += input[i];

                if (CheckDigit(currentNumber) != "NO")
                {
                    countDigits++;
                    currentNumber = String.Empty;
                }

            }

            ulong power = countDigits - 1;

            currentNumber = String.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                currentNumber += input[i];

                if (CheckDigit(currentNumber) != "NO")
                {
                    countDigits++;
                    result += ulong.Parse(CheckDigit(currentNumber)) * Power(power);
                    currentNumber = String.Empty;
                    power--;
                }

            }



            Console.WriteLine(result);
        }
        public static ulong Power(ulong power)
        {
            ulong result = 1;

            for (ulong i = 0; i < power; i++)
            {
                result *= 168;
            }

            return result;
        }

        public static string CheckDigit(string digit)
        {
            string result = "NO";
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i].ToString() == digit)
                {
                    result = i.ToString();
                }
            }


            return result;
        }

        private static void FillTheArray(string[] digits, ref int nextDigit, ref int counter)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if (i < 26)
                {
                    string digit = Convert.ToChar(i + 'A').ToString();
                    digits[i] = digit;

                }
                else
                {
                    if (i % 26 == 0)
                    {
                        nextDigit++;
                        counter = 0;
                        string digit = Convert.ToChar(counter + 'A').ToString();
                        digits[i] = String.Format("{0}{1}", Convert.ToChar(nextDigit + 'a').ToString(), digit);
                        counter++;
                    }
                    else
                    {
                        string digit = Convert.ToChar(counter + 'A').ToString();
                        digits[i] = String.Format("{0}{1}", Convert.ToChar(nextDigit + 'a').ToString(), digit);
                        counter++;
                    }
                }

            }
        }
    }
}
