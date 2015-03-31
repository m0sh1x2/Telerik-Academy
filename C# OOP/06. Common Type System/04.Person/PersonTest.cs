namespace _04.Person
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class PersonTest
    {
        static void Main(string[] args)
        {
            var horo = new Person("Horo The Fox", null);
            var blair = new Person("Blair The Witch", 19);
            Console.WriteLine(horo.ToString());
            Console.WriteLine(blair.ToString());
        }
    }
}
