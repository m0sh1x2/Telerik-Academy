namespace _08.Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CustomEventArgs : EventArgs
    {
        private string message;
        public CustomEventArgs(string s)
        {
            message = s;
        }
        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }
    }
}
