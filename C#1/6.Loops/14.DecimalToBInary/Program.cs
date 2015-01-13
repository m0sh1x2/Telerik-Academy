using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DecimalToBInary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");

            

        }
        public static string convert(string n)
        {
            string result = string.Empty;
            switch (n)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    result = n;
                    break;
                case "10":
                    result = "A";
                    break;
                case "11":
                    result = "B";
                    break;
                case "12":
                    result = "C";
                    break;
                case "13":
                    result = "D";
                    break;
                case "14":
                    result = "E";
                    break;
                case "15":
                    result = "F";
                    break;
                default:
                    result = "0";
                    break;
            }
            return result;

        }
    }
}
