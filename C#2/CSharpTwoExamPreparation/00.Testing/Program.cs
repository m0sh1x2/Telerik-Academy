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
            var beers = new string[] { "beer1", "beer2", "beer3" };

            Console.WriteLine(String.Join("\n",beers));
        }
    }
}
