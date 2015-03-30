namespace Shapes
{
    public class Triangle : Shape
    {
        // a constructor which inherits the 
        // abstract base class shape
        public Triangle(decimal width, decimal height)
            : base(width, height)
        {
        }

        // overriden method for calculating surface
        // of a triangle by the given formula in the task
        public override decimal CalculateSurface()
        {
            decimal surface = (this.Height * this.Width) / 2;
            return surface;
        }
    }
}
