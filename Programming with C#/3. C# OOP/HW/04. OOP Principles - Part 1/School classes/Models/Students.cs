namespace School_classes.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Students : Person
    {
        private int uniqueClassNumber;

        public Students(string name, int uniqueClassNumber)
            :base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public int UniqueClassNumber
        {
            get
            {
                return this.uniqueClassNumber;
            }

            private set
            {
                if (this.uniqueClassNumber < 0 )
                {
                    throw new ArgumentException("The Unique Class Number is invalid.");
                }

                this.uniqueClassNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name st.: {0}", this.Name);
        }
    }
}
