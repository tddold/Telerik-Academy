using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Student
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string facultyNumber;
        private string phone;
        private MailAddress email;
        private List<int> marks;
        private Group group;

        public Student(string firstName, string lastName, string facultyNumber, string phone,
            MailAddress email, List<int> marks, Group group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = new List<int>();
            this.Group = group;
        }

        public Student()
        {
            // TODO: Complete member initialization
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                CheckName(value);

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                CheckName(value);

                this.lastName = value;
            }
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                CheckFacultyNum(value);

                this.facultyNumber = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                CheckPhone(value);

                this.phone = value;
            }
        }

        public MailAddress Email
        {
            get
            {
                return this.email;
            }

            set
            {
                CheckEmail(value);

                this.email = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }

            set
            {
                CheckMarks(value);

                this.marks = value;
            }
        }

        public Group Group
        {
            get
            {
                return this.group;
            }

            set
            {
                CheckGroup(value);

                this.group = value;
            }
        }

        public override string ToString()
        {
            return string.Format("First name: {0}\nLast name: {1}\nFaculty number: {2}\n" +
                                 "Group number: {3}\nMarks: {4}\nPhone: {5}\nEmail: {6}",
                this.firstName, this.lastName, this,facultyNumber, this.group,
                string.Join(", ", this.marks), this.phone, this.email);
        }

        private void CheckName(string value)
        {
            if (value== null )
            {
                throw new ArgumentException("First name is empty.");
            }
        }

        private void CheckFacultyNum(string value)
        {
            if (value == null)
            {
                throw new ArgumentException("First name is empty.");
            }
        }

        private void CheckPhone(string value)
        {
            if (value == null)
            {
                throw new ArgumentException("First name is empty.");
            }
        }

        private void CheckEmail(MailAddress value)
        {
            if (value == null)
            {
                throw new ArgumentException("First name is empty.");
            }
        }

        private void CheckMarks(List<int> value)
        {
            if (value == null)
            {
                throw new ArgumentException("First name is empty.");
            }
        }

        private void CheckGroup(global::Student.Group value)
        {
            if (value == null)
            {
                throw new ArgumentException("First name is empty.");
            }
        }

    }
}
