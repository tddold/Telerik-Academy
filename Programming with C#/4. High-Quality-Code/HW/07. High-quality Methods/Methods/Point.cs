namespace Methods
{
    using System;

    public struct Point
    {
        private static readonly Point BasePoint;

        static Point()
        {
            BasePoint = new Point(0, 0);
        }

        public Point(double x, double y)
            : this()
        {
            this.X = x;
            this.Y = y;
        }

        public static Point StartPoint
        {
            get
            {
                return BasePoint;
            }
        }

        public double X { get; set; }

        public double Y { get; set; }

        public override string ToString()
        {
            return string.Format("{{0}, {1}}", this.X, this.Y);
        }
    }
}
