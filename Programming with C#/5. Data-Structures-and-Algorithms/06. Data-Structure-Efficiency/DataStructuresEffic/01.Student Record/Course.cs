namespace DataStructuresEfficiency
{
    using System;

    public class Course : IComparable<Course>, IEquatable<Course>
    {
        public Course(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public int CompareTo(Course other)
        {
            return string.Compare(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Course);
        }

        public bool Equals(Course other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return string.Compare(this.Name, other.Name, StringComparison.OrdinalIgnoreCase) == 0;
        }
    }
}
