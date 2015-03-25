using School.Interfaces;

namespace School.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;   

    public class Disciplines : ICommentable
    {
        private string name;
        private int lecturesID;
        private int exerciseID;

        public Disciplines()
        {

        }

        public Disciplines(string name, int lecturesID, int exerciseID)
        {
            this.Name = name;
            this.LectureeID = lecturesID;
            this.ExerciseID = exerciseID;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name is empty.");
                }

                this.name = value;
            }
        }

        public int LectureeID
        {
            get { return this.lecturesID; }
           private set
            {
                if (this.lecturesID < 0)
                {
                    throw new ArgumentException("Invalid lecturesID.");
                }

                this.lecturesID = value;
            }
        }

        public int ExerciseID
        {
            get { return this.exerciseID; }
            private set
            {
                if (this.exerciseID < 0)
                {
                    throw new ArgumentException("Invalid exerciseID.");
                }

                this.exerciseID = value;
            }
        }
        public List<string> Comments { get; set; }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }

        public override string ToString()
        {
            return "Discipline" + this.Name;
        }
    }
}
