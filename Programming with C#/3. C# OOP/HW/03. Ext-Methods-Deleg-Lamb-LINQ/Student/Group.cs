namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Group
    {
        private int groupNumber;
        private string departmentName;

        public Group(int groupNum, string deptName)
        {
            this.GroupNumber = groupNum;
            this.DepartamenrName = deptName;
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            set
            {
                this.groupNumber = value;
            }
        }

        public string DepartamenrName
        {
            get
            {
                return this.departmentName;
            }

            set
            {
                this.departmentName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("\t -> Group Number: {0},\n\t -> Departament Name: {1}", this.groupNumber, this.departmentName);
        }
    }
}
