namespace Shapes
{
    public class Rectangle : Shape
    {
        // a constructor which inherits the 
        // abstract base class shape
        public Rectangle(decimal width, decimal height)
            : base(width, height)
        {
        }

        // overriden method for calculating surface
        // of a rectangle by the given formula in the task
        public override decimal CalculateSurface()
        {
            decimal surface = this.Height * this.Width;
            return surface;
        }
    }
}
