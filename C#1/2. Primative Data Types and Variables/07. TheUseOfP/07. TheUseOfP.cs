using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUseOfP
{
    class TheUseOfP
    {
        static void Main(string[] args)
        {
            string string1 = "The \"use\" of quatations causes";
            string string2 = "causes difficulties.";

            string string3 = "The \"use\"" +" of quatations causes";
            string string4 = "causes difficulties.";
            Console.WriteLine(string1+string2);
            Console.WriteLine("{0}{1}",string3,string4);
        }
    }
}
