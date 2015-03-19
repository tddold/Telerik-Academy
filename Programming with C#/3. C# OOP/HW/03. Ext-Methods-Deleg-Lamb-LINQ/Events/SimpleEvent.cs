namespace Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    // Define class to hold even info
    public class SimpleEvent : EventArgs
    {
        private string message;

        public SimpleEvent(string msg)
        {
            this.message = msg;
        }

        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }
    }
}
