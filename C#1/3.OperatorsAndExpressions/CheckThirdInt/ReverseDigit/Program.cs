using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseDigit
{
    class Program
    {
       
        public static string revO(string a){
            char[] array = a.ToCharArray();
            Array.Reverse(array);
            
            return new string(array);
        }

        public static void lastFront(string a)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(a[3]);
            sb.Append(a[0]);
            sb.Append(a[1]);
            sb.Append(a[2]);
            sb.AppendLine();

            Console.WriteLine(sb);

        }
        public static void secondAndThird(string a) 
        {
            StringBuilder sb = new StringBuilder();

            
            sb.Append(a[0]);
            sb.Append(a[2]);
            sb.Append(a[1]);
            sb.Append(a[3]);
            //sb.AppendLine();

            Console.WriteLine(sb);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter string of 4 digits ! ");
            string number = Console.ReadLine();

            
            Console.WriteLine(revO(number));
            lastFront(number);
            secondAndThird(number);
        }
    }
}
