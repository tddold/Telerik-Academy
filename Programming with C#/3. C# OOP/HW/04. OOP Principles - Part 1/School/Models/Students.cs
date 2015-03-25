using School.Interfaces;

namespace School.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;    

    public class Students : Person
    {

        private int classID;

        public Students(string name, int classID)
            : base(name)
        {           
            this.ClassID = classID;
        }

        public int ClassID
        {
            get { return this.classID; }
            private set
            {
                this.classID = value;
            }
        }
    }
}
