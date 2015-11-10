namespace DataStructuresEfficiency
{
    using System;

    public class Student : IComparable<Student>
    {
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CompareTo(Student other)
        {
            var compare = string.Compare(this.LastName, other.LastName, StringComparison.Ordinal);

            if (compare == 0)
            {
                compare = string.Compare(this.FirstName, other.FirstName, StringComparison.Ordinal);
            }

            return compare;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
