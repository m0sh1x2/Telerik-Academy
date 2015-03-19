namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class IEnumerableMain
    {
        static void Main(string[] args)
        {
            IEnumerable<double> test = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(test.Sum());
            Console.WriteLine(test.Average());
            Console.WriteLine(test.Product());
            Console.WriteLine(test.MinValue());
            Console.WriteLine(test.MaxValue());


        }
    }
}
