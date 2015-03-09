namespace MobilePhone
{
    using System;
    using System.Text;

    public class Battery
    {
        // defining the battery information (fields)
        private string model;
        private uint hoursIdle;
        private uint hoursTalk;
        private BatteryType type;

        // making the constructor
        public Battery(string model = null, uint hoursIdle = 0, uint hoursTalk = 0, BatteryType type = 0)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }

        // making the properties - making it public so it can be adjusted by the outside
        public string Model
        {
            get { return this.model; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorect model!");
                }

                this.model = value;
            }
        }

        public uint HoursIdle
        {
            get { return this.hoursIdle; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorect hours idle!");
                }

                this.hoursIdle = value;
            }
        }

        public uint HoursTalk
        {
            get { return this.hoursTalk; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorect hours talk");
                }

                this.hoursTalk = value;
            }            
        }
    }
}
