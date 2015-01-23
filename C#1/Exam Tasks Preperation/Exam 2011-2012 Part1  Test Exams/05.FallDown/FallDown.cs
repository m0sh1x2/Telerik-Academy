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

            //input
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = int.Parse(Console.ReadLine());
            }

            //solution
            for (int i = 0; i < 8; i++)
            {
                for (int line = 7; line > 0; line--)
                {
                    for (int position = 0; position < 8; position++)
                    {
                        if ((matrix[line] >> position & 1) == 0 && (matrix[line - 1] >> position & 1) == 1)
                        {
                            matrix[line] |= (1 << position);
                            matrix[line - 1] ^= (1 << position);
                        }
                    }
                }
            }



            //output
            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }
        }
    }
}
