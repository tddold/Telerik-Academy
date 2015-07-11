namespace Figure_rotation
{
    using System;

    public class Figure
    {
        private double width;
        private double height;

        /// <summary>
        /// Initializes a new instance of the <see cref="Figure"/> class.
        /// </summary>
        /// <param name="width">The width of the figure.</param>
        /// <param name="height">The height of the figure.</param>
        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or sets the width of the figure.
        /// </summary>
        public double Width
        {
            get
            {
                return this.Width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be greater than zero.");
                }

                this.Width = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of the figure.
        /// </summary>
        public double Height
        {
            get
            {
                return this.Height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be greater than zero.");
                }

                this.Height = value;
            }
        }

        /// <summary>
        /// Rotate figure by given angle of rotation.
        /// </summary>
        /// <param name="figure">The figure to rotate.</param>
        /// <param name="rotationAngel">The angle of rotation.</param>
        /// <returns>A new figure after rotation by the given angle of rotation.</returns>
        public static Figure Ratate(Figure figure, double rotationAngel)
        {
            double cosValue = Math.Abs(Math.Cos(rotationAngel));
            double sinValue = Math.Abs(Math.Sin(rotationAngel));

            double newWidth = (cosValue * figure.Width) + (sinValue * figure.Height);
            double newHeight = (sinValue * figure.Width) + (cosValue * figure.Height);

            var rotatedFigure = new Figure(newWidth, newHeight);

            return rotatedFigure;
        }
    }
}
