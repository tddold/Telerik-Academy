namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Group
    {
        private string groupNumber;
        private string departmentName;

        public Group(string groupNum, string deptName)
        {
            this.GroupNumber = groupNum;
            this.DepartamenrName = deptName;
        }

        public string GroupNumber
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
    }
}
