using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SHeets
{
    class Sheets
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());



            //int n = 1337;
            for (int i = 10; i >= 0; i--)
            {
                /*
                Console.WriteLine("-----------------------");
                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                Console.WriteLine(Convert.ToString(1, 2).PadLeft(32, '0'));
                Console.WriteLine(Convert.ToString(n & 1, 2).PadLeft(32, '0'));
                */
                if ((n&1) ==0)
                {
                    Console.WriteLine("A{0}",i);
                    //Console.WriteLine(n & 1);
                }


                //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                
                n >>= 1;
            }
            

        }
    }
}
