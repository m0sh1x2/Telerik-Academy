using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FallDOwnByMe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrix = new int[8];
            for (int i = 0; i < 8; i++)
            {
                matrix[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 8; i++)
			{
			 
			
                for (int line = 7; line > 0; line--)
                {

                    for (int bitPosition = 7; bitPosition < 0; bitPosition++)
                    {
                        if (
                            ((matrix[line] >>bitPosition &1) ==0)
                            &&
                            ((matrix[line-1] >> bitPosition & 1) == 1))
                        {
                            matrix[line] |= (line >> 1);
                            matrix[line - 1] ^= (line >> 1);
                        }
                    }
                }

            }

            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }
        }
    }
}
