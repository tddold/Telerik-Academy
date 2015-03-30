namespace Shapes
{
    public class Square : Shape
    {
        public Square(decimal size)
            : base(size, size)
        {
            this.Size = size;
        }

        public decimal Size { get; set; }

        public override decimal CalculateSurface()
        {
            decimal surface = this.Width * this.Width;
            return surface;
        }
    }
}
