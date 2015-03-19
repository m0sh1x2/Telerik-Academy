using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Events
{
    class Subscriber
    {
        private string id;
        public Subscriber(string ID, Publisher pub)
        {
            id = ID;
            pub.RaiseCustomEvent += HandleCustomEvent;
        }
        void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine(id + " recieved this message: {0}",e.Message);
        }
    }
}
