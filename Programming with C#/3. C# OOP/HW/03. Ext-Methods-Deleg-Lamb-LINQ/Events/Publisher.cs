namespace Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    

    // Calss the publishes an event
    public class Publisher
    {
        public delegate void CustomEventHandler(object sender, EventArgs e);

        public event CustomEventHandler RaiseCustomEvent;

        public void RaiseSampleEvent()
        {
            Console.WriteLine("An event will be raised");
            OnRaiseCustomEvent(new SampleEvent("This is the custom event"));
        }

        protected virtual void OnRaiseCustomEvent(SampleEvent e)
        {
            CustomEventHandler handler = RaiseCustomEvent;

            // Event will be null if there are no subscribers 
            if (handler != null)
            {
                e.Message += String.Format(" at {0}", DateTime.Now);

                // Use the () operator to raise the event.
                handler(this, e);
            }          
        }
    }
}
