namespace Methods
{
    using System;

    /// <summary>
    /// Class for students, containing basic information and age comparer .
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Constructor for class Student.
        /// </summary>
        public Student()
        {
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo { get; set; }

        /// <summary>
        /// The method compare two students by their birth date.
        /// </summary>
        /// <param name="other">String that contains information about birth date.</param>
        /// <returns>Boolean variable - true if the first students is older than the second, false - otherwise</returns>
        public bool IsOlderThan(Student other)
        {
            DateTime firstDate = DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
            DateTime secondDate = DateTime.Parse(other.OtherInfo.Substring(other.OtherInfo.Length - 10));
            return firstDate > secondDate;
        }
    }
}