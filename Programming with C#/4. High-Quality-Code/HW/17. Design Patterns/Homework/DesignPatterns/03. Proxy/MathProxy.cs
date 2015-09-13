namespace Proxy.Example
{
    /// <summary>
    /// The 'Proxy Object' class
    /// </summary>
    public class MathProxy : IMath
    {
        private Math math = new Math();

        public double Add(double x, double y)
        {
            return this.math.Add(x, y);
        }

        public double Sub(double x, double y)
        {
            return this.math.Sub(x, y);
        }

        public double Mul(double x, double y)
        {
            return this.math.Mul(x, y);
        }

        public double Div(double x, double y)
        {
            return this.math.Div(x, y);
        }
    }
}