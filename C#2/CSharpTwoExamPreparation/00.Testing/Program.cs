using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var beers = new string[] { "beer1", "beer2", "beer3" };

            Console.WriteLine(String.Join("\n", beers));
            */


            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var prime = list.FindAll(x => (x % 2) == 0);

            Console.WriteLine(String.Join("\n", list));
        }
    }
}
