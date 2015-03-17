namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class Timer
    {
        private int hour;
        private int minute;
        private int second;
        private int seconds;

        public Timer(int seconds)
        {
            this.seconds = seconds;
        }

        public delegate void Delegate(object clock, TimeInfoEventArgs timeInformation);

        public Delegate SecondChanged;

        public void Run()
        {
            for (; ; )
            {
                // get the curent time
                DateTime dt = DateTime.Now;

                // if the second has changed, notify the subscribers
                if (dt.Second != second)
                {
                    // create the TimeInfoEventArgs object to pass to the subscriber
                    TimeInfoEventArgs timeInformation =
                        new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);

                    // if anyone has subscribed, notify them
                    if (SecondChanged != null)
                    {
                        SecondChanged(this, timeInformation);
                    }
                }

                // sleep T milliseconds
                Thread.Sleep(second * 1000);

                // update the state
                this.second = dt.Second;
                this.minute = dt.Minute;
                this.hour = dt.Hour;
            }
        }
    }
}
