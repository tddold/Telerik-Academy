/*Problem 2. IClonable
 * Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's
 * fields into a new object of type Student.
 * 
Problem 3. IComparable
 * Implement the IComparable<Student> interface to compare students by names (as first criteria, in 
 * lexicographic order) and by social security number (as second criteria, in increasing order).*/

namespace Student_class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Mail;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private uint SSN;
        private string permanentAddress;
        private string mobilePhone;
        private MailAddress email;
        private string course;
        private Specialty specialty;
        private University university;
        private Faculty faculty;

        public Student(string firstName, string middleName, string lastName,
            uint SSN, string permanentAddress, string mobilePhone, MailAddress email, string course,
            Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSNum = SSN;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName
        {
            get { return this.firstName; }

            set { this.firstName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }

            set { this.middleName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }

            set { this.lastName = value; }
        }

        public uint SSNum
        {
            get { return this.SSN; }

            set { this.SSN = value; }
        }

        public string PermanentAddress
        {
            get { return this.permanentAddress; }

            set { this.permanentAddress = value; }
        }

        public string MobilePhone
        {
            get { return this.mobilePhone; }

            set { this.mobilePhone = value; }
        }

        public MailAddress Email
        {
            get { return this.email; }

            set { this.email = value; }
        }

        public string Course
        {
            get { return this.course; }

            set { this.course = value; }
        }

        public Specialty Specialty
        {
            get { return this.specialty; }

            set { this.specialty = value; }
        }

        public University University
        {
            get { return this.university; }

            set { this.university = value; }
        }

        public Faculty Faculty
        {
            get { return this.faculty; }

            set { this.faculty = value; }
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.Equals(secondStudent))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            if (!firstStudent.Equals(secondStudent))
            {
                return true;
            }

            return false;
        }
        
        public override bool Equals(object obj)
        {
            var student = (Student)obj;

            if (student == null)
            {
                return false;
            }

            if (student.firstName == this.firstName && student.middleName == this.middleName &&
                student.lastName == this.lastName && student.SSN == this.SSN &&
                student.permanentAddress == this.permanentAddress && student.mobilePhone == this.mobilePhone)
            {
                return true;
            }

            return false;
        }       

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(string.Format("First Name: {0,11}", this.FirstName));
            sb.AppendLine(string.Format("Middle Name: {0,12}", this.MiddleName));
            sb.AppendLine(string.Format("Last Name: {0,14}", this.LastName));
            sb.AppendLine(string.Format("SSN number: {0,15}", this.SSNum));
            sb.AppendLine(string.Format("Permanent address: {0,13}", this.PermanentAddress));
            sb.AppendLine(string.Format("Mobile Phone: {0,15}", this.MobilePhone));
            sb.AppendLine(string.Format("Email address: {0,17}", this.Email));
            sb.AppendLine(string.Format("Course: {0,13}", this.Course));
            sb.AppendLine(string.Format("University: {0,22}", this.University));
            sb.AppendLine(string.Format("Faculty: {0,35}", this.Faculty));
            sb.AppendLine(string.Format("Specialty: {0,23}", this.Specialty));

            return sb.ToString();
        }

        public override int GetHashCode()
        {
            return this.SSNum.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public object Clone()
        {
            var newStudent = new Student(this.FirstName, this.MiddleName, this.LastName,
                this.SSNum, this.PermanentAddress, this.MobilePhone, this.Email, this.Course,
                this.Specialty, this.University, this.Faculty);

            return newStudent;
        }

        public int CompareTo(Student otherStudent)
        {
            if (this.FirstName.CompareTo(otherStudent.FirstName) == -1)
            {
                return -1;
            }
            else if (this.firstName.CompareTo(otherStudent.firstName) == 0)
            {
                if (this.SSNum > otherStudent.SSNum)
                {
                    return -1;
                }
                else if (this.SSNum < otherStudent.SSNum)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if (this.FirstName.CompareTo(otherStudent.firstName) == 1)
            {
                return 1;
            }

            return -1;
        }
    }
}
