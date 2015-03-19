
namespace _06.By6and7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[80];

            Console.WriteLine("LAMBDA : ");
            //fill the array
            for (int i = 0; i < 80; i++)
            {
                array[i] = i;
            }
            var result =
                from number in array
                where number % 7 == 0 && number % 3 == 0 && number > 0
                select number;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("LINQ :");
            var linqresult = array.Where(x => x % 7 == 0 && x % 3 == 0 && x > 0);
            foreach (var item in linqresult)
            {
                Console.WriteLine(item);
            }
        }
    }
}
