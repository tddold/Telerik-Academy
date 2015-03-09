namespace MobilePhone
{
    using System;

    public class Display
    {
        // defining the display information (fields)
        private double size;
        private uint colors;

        // making the constructor
        public Display(double size = 0, uint colors = 0)
        {
            this.size = size;
            this.colors = colors;
        }

        public double Size
        {
            get { return this.size; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorect size!");
                }

                this.size = value;
            }
        }

        public uint Colors
        {
            get { return this.colors; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorect colors!");
                }

                this.colors = value;
            }
        }
    }
}
