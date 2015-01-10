using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a<1 | a > 9)
            {
                Console.WriteLine("invalid score");                
            }
            if (a >=1 && a <=3)
            {
                Console.WriteLine(a*10);
            }
            if (a >= 4 && a <= 6)
            {
                Console.WriteLine(a * 100);
            }
            if (a >= 7 && a <= 9)
            {
                Console.WriteLine(a * 1000);
            }

            
        }
    }
}
