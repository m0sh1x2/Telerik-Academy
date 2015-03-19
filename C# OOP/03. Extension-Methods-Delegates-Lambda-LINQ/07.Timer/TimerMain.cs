namespace _07.Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class TimerMain
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(5);

            timer.SomeMethods += Test1;
            timer.SomeMethods += Test2;

            timer.ExecuteMethods();
        }

        public static void Test1()
        {
            Console.WriteLine("Test1");
        }
        public static void Test2()
        {
            Console.WriteLine("Test2");
        }
    }
}
