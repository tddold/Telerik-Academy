namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tester
    {
        private int seconds;

        public Tester(int seconds)
        {
            this.seconds = seconds;
        }

        public void Run()
        {
            // create a new clock
            Timer theTimer = new Timer(this.seconds);

            // create the display and tell it to subscribe to the clock just created
            DisplayTimer dc = new DisplayTimer();
            dc.Subscribe(theTimer);

            // Get the clock started
            theTimer.Run();
        }
    }
}
