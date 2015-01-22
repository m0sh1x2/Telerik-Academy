using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.NaBabaMiSmetalnika
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrix = new int[8];


            // input
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = int.Parse(Console.ReadLine());
            }

            // solution

            for (int i = 0; i < 8; i++)
            {
                for (int line = 7; line > 0; line--)
                {
                    for (int bitPosition = 0; bitPosition < matrix.Length; bitPosition++)
                    {
                        if ((matrix[line] >> bitPosition & 1) == 0 && (matrix[line - 1] >> bitPosition & 1) == 1)
                        {
                            matrix[line] |= (1 << bitPosition);
                            matrix[line - 1] ^= (1 << bitPosition);
                        }
                    }
                }
            }


     

            // output
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(matrix[i]);
            }

        }
    }
}
