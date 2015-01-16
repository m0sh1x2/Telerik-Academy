using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FallDown
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[8];

            for (int i = 0; i < 8; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                
            }

            

            for (int i = 0; i < 8; i++)
            {
                for (int line = 7; line > 0; line--)
                {
                    for (int bitPosition = 0; bitPosition < 8; bitPosition++)
                    {
                        if (((nums[line] >> bitPosition & 1) == 0) && (((nums[line-1] >> bitPosition & 1) == 1)))
                        {
                            nums[line] |= (1 << bitPosition);
                            nums[line-1] ^= (1 << bitPosition);
                        }
                    }
                }
            }

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

        }
    }
}
