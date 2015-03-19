namespace _07.Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Threading;

    public class Timer
    {
        public delegate void TimerDlg();
        public TimerDlg SomeMethods { get; set; }
        public int timeInterval;
        public int TimeInterval
        {
            get { return this.timeInterval; }

            set { this.timeInterval = value; }
        }
        public Timer(int seconds)
        {
            this.TimeInterval = seconds;
        }

        public void ExecuteMethods()
        {
            while (true)
            {
                this.SomeMethods();
                Thread.Sleep(this.timeInterval * 1000);
            }
        }
    }
}
