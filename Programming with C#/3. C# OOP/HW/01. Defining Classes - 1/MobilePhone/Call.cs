namespace MobilePhone
{
    using System;
    public class Call
    {
        // making the wanted fields for the class Call
        private DateTime callDate;
        private DateTime callTime;
        private string dialledNumber;
        private uint duration;

        public Call(DateTime date, DateTime time, string dialledNumber = "112", uint duration = 60)
        {
            this.callDate = date;
            this.callTime = time;
            this.dialledNumber = dialledNumber;
            this.duration = duration;
        }

        // making the properties
        public DateTime CallDate
        {
            get { return this.callDate; }

            set { this.callDate = value; }
        }

        public DateTime CallTime
        {
            get { return this.callTime; }

            set { this.callTime = value; }
        }

        public string DialledNumber
        {
            get { return this.dialledNumber; }

            set { this.dialledNumber = value; }
        }

        public uint Duration
        {
            get { return this.duration; }

            set { this.duration = value; }
        }
    }
}
