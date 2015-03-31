namespace _05.BitArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BitArrayMain
    {
        static void Main(string[] args)
        {
            var array1 = new BitArray64(5u);
            var array2 = new BitArray64(10u);
            array1[0] = 0;
            Console.WriteLine(array1[0]);

            Console.WriteLine(array1.CompareTo(array2));
            Console.WriteLine(array2 == array1);
        }
    }
}
