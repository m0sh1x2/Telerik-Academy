using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ASCll
{
    class ASCll
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 128; i++)
            {
                char c = (char)i;
                Console.Write(" {0}",c);
            }
            Console.WriteLine();
        }
    }
}
