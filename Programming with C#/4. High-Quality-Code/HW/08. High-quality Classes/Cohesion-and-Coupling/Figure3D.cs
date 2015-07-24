namespace CohesionAndCoupling
{
    using System;

    internal class Figure3D : IDiagonals2D, IDiagonal3D
    {
        private double width;

        private double height;

        private double depth;

        public Figure3D(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (!this.ValidateSide(value))
                {
                    throw new ArgumentOutOfRangeException("Width must be a positive number.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (!this.ValidateSide(value))
                {
                    throw new ArgumentOutOfRangeException("Height must be a positive number.");
                }

                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (!this.ValidateSide(value))
                {
                    throw new ArgumentOutOfRangeException("Depht must be a positive number.");
                }

                this.depth = value;
            }
        }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalcDiagonalXy()
        {
            double distance = DistanceUtils.CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalcDiagonalXyz()
        {
            double distance = DistanceUtils.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalcDiagonalXz()
        {
            double distance = DistanceUtils.CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalcDiagonalYz()
        {
            double distance = DistanceUtils.CalcDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }

        private bool ValidateSide(double value)
        {
            return value > 0;
        }
    }
}
