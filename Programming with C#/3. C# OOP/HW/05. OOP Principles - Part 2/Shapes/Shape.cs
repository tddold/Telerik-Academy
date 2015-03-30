namespace Shapes
{
    public abstract class Shape
    {
        // fields for width and height
        private decimal width;
        private decimal height;

        public Shape(decimal width, decimal heigth)
        {
            this.Width = width;
            this.Height = heigth;
        }

        // property for the width field
        public decimal Width 
        {
            get { return this.width; }
            set { this.width = value; }
        }

        // property for the height field
        public decimal Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        // an abstract method which should be invented by all 
        // classes that inherit this class
        public abstract decimal CalculateSurface();
    }
}
