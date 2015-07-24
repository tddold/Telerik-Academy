namespace Abstraction
{
    using System;

    public abstract class Figure : IFigure
    {
        protected Figure()
        {
        }

        public abstract double CalcPerimeter();

        public abstract double CalcSurface();
    }
}
