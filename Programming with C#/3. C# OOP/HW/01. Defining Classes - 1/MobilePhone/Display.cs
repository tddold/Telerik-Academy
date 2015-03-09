namespace MobilePhone
{
    using System;

    class Display
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
    }
}
