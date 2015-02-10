using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortByStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new string[] { "abc", "a", "abcd", "ab", "abcde" };
            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));

            Console.WriteLine(String.Join(Environment.NewLine,array));

        }
    }
}
