namespace Students_and_workers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student : Human
    {
        private int grade;

        // a constructor for the student class
        public Student(string firstName, string lastName, int grade)
        {
            this.Grade = grade;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Grade
        {
            get { return this.grade; }

            private set { this.grade = value; }
        }

        public override string ToString()
        {
            return string.Format("Student name: {0} {1}", this.FirstName, this.LastName);
        }
    }
}
