namespace Students_and_workers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        // a property for the first name of the Human
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        // a property for the last name of the Human
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}", this.FirstName, this.LastName);
        }
    }
}
