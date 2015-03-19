namespace GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GenericClassMain
    {
        static void Main(string[] args)
        {
            var deque = new Deque<int>();

            deque.AddBack(1);
            deque.AddFront(1);
            Console.WriteLine(deque.RemoveFront());
            Console.WriteLine(deque.RemoveBack());
            Console.WriteLine();
        }
    }
}
