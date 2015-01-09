using System;
    class asignNull
    {
        static void Main()
        {
            int? first = null;
            double? second = null;

            Console.WriteLine("First: {0}, Second: {1}",first,second);
            Console.WriteLine("Adding values 3 and 4!");
            first = 3;
            second = 4;
            Console.WriteLine("First: {0}, Second: {1}", first, second);
        }
    }

