namespace _08.Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class EventsMain
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();

            var sub1 = new Subscriber("sub1", pub);
            var sub2 = new Subscriber("sub2", pub);

            while (true)
            {
                pub.DoSomething();
                System.Threading.Thread.Sleep(1000); //Am I doing this correct ?!?!??!
                
            }
            


        }
    }
}
