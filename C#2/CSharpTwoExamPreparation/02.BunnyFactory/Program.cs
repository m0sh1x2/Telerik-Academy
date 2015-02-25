using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.BunnyFactory
{
    class Program
    {

        public static List<int> cages = new List<int>();
        public static List<int> currentCages = new List<int>();

        public static bool isChecked;
        public static int currentSum, currentProduct = 1;
        public static string sum = String.Empty, product = String.Empty;
        public static int publicAmountOfCages = 0;
        public static string result = String.Empty;


        static void Main(string[] args)
        {


            ReadInput();
            FactoryLogic();

        }

        private static void FactoryLogic()
        {

            int product = 1;
            int sum = 0;

            int nextNumber = 0; // next number after checking the sum and product

            string result = String.Empty;


            for (int i = 0; i < 2; i++)
            {


                result = GetProductAndSum(i);


                result += GetRemainingNumbers(publicAmountOfCages + 1);

                cages.Clear();
                //cages = result.ToList();
                foreach (var item in result)
                {
                    cages.Add(int.Parse(item.ToString()));
                }

                Console.WriteLine("result : " + result);
                Console.WriteLine("sum : " + currentSum);
                Console.WriteLine("product " + currentProduct);


                currentSum = 0;
                currentProduct = 0;
                product = 0;
                sum = 0;
                result = String.Empty;
            }

        }

        private static string GetRemainingNumbers(int i)
        {
            string remaining = String.Empty;

            for (int j = i; j < cages.Count; j++)
            {
                remaining += cages[j];
            }
            return remaining;
        }

        private static string GetProductAndSum(int i)
        {
            int amountOfCages = 0;
            for (int j = 0; j <= i; j++)
            {
                //get sum of first cages
                amountOfCages += cages[j];
            }
            publicAmountOfCages = amountOfCages;
            //Get sum and product 
            int nextNum = 0;

            if (i >= 1)
            {
                nextNum = 1;
            }

            for (int j = i + 1; j <= amountOfCages + nextNum; j++)
            {
                //calculate the sum and the product from the first number
                int currentNumber = cages[j];

                currentSum += currentNumber;
                currentProduct *= currentNumber;

            }
            //set the sum and product to the result
            sum = Regex.Replace(currentSum.ToString() + "1", @"[0-1]", string.Empty);
            product = Regex.Replace(currentProduct.ToString() + "1", @"[0-1]", string.Empty);

            //Set the result
            result = sum + product;
            return sum + product;


        }



        private static void ReadInput()
        {
            string n;
            while (true)
            {
                n = Console.ReadLine();
                if (n != "END")
                {
                    cages.Add(int.Parse(n));
                }
                else
                {
                    break;
                }
            }
        }
    }
}
