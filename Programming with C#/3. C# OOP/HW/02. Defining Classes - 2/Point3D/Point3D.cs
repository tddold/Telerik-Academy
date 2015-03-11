namespace Point3D
{
    using System;

    public struct Point3D
    {
        private static readonly Point3D startPoint;
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public static Point3D StartPoint
        {
            get
            {
                return startPoint;
            }
        }

        static Point3D()
        {
            startPoint = new Point3D(0, 0, 0);
        }

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return string.Format("X --> {0}\nY --> {1}\nZ --> {2}", this.X, this.Y, this.Z);
        }
    }
}
