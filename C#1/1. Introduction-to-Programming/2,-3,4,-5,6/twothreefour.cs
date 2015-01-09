using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__3_4__5_6
{
    class twothreefour
    {
        static void Main(string[] args)
        {
            for (int i = 2 ; i < 11; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("-" + i + ",");
                }
                else
                {
                    Console.Write(i + ",");
                }
                
            }
        }
    }
}
