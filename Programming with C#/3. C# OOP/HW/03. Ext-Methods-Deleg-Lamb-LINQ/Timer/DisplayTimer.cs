using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public class DisplayTimer
    {
        public void Subscribe(Timer theTimer)
        {
            theTimer.SecondChanged += new Timer.Delegate(TimerHasChenged);
        }

        public void TimerHasChenged(object clock, TimeInfoEventArgs timeInformation)
        {
            DelegateTSeconds eachDelegateSeconds = TestTimer.TestMethod;
            eachDelegateSeconds();
        }
    }
}
