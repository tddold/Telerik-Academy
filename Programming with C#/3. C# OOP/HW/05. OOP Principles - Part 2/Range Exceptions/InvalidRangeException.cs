namespace Range_Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InvalidRangeException<T> : Exception
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private T start;
        private T end;

        public InvalidRangeException(string message, T start, T end)
            : base(message)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start
        {
            get { return this.start; }

            set { this.start = value; }
        }

        public T End
        {
            get { return this.end; }

            set { this.end = value; }
        }
    }
}
