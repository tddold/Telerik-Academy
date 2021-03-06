﻿namespace Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    // Define class to hold even info
    public class SampleEvent : EventArgs
    {
        private string message;

        public SampleEvent(string msg)
        {
            this.Message = msg;
        }

        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }
    }
}
