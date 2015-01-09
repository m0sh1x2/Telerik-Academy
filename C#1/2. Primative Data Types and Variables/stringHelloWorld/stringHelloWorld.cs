using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringHelloWorld
{
    class stringHelloWorld
    {
        static void Main(string[] args)
        {
            string string1 = "Hello";
            string string2 = "World";
            object potato = string1 + " " + string2;
            string string3 = (string)potato;
            Console.WriteLine("potato = " + potato);
            Console.WriteLine("string 3 = " + string3);

        }
    }
}
