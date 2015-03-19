namespace Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public delegate void CustomEventHandler(object sender, EventArgs e);
    // Calss the publishes an event
     public class Publisher
    {
         public event EventHandler RaiseSampleEvent;


    }
}
