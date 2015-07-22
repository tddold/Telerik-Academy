namespace Methods
{
    using System;

    /// <summary>
    /// Class for points, containing basic information(x, y) and override ToString method.
    /// </summary>
    public struct Point
    {
        private static readonly Point BasePoint;

        /// <summary>
        /// Base constructor for the class Point.
        /// </summary>
        /// <see cref="Point"/>
         static Point()
        {
            BasePoint = new Point(0, 0);
        }

        /// <summary>
        /// Constructor for the class Point.
        /// </summary>
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

        /// <summary>
        /// The method override ToString.
        /// </summary>
        /// <returns>Formatted string.</returns>
        public override string ToString()
        {
            return string.Format("{{0}, {1}}", this.X, this.Y);
        }
    }
}
