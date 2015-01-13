using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.GDC
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(GDC(a,b));
        }
        public static int GDC(int a, int b)
        {
            while (a != 0 && b!=0)
            {
                if (a>b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            if (a==0)
            {
                return b;
            }
            else
            {
                return a;
            }
            return a;
        }
    }
}
