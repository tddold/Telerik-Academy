namespace School_classes.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Disciplines : SchoolObject
    {
        private int numberOfLectures;
        private int numberOfExercises;

        public Disciplines(string name, int numberOfLecture, int numberOfExercises)
            :base(name)
        {
            this.NumberOfLecture = numberOfLecture;
            this.NumberOfExercises = numberOfExercises;
        }

        public int NumberOfLecture
        {
            get
            {
                return this.numberOfLectures;
            }

            private set
            {
                if (this.numberOfLectures < 0)
                {
                    throw new ArgumentException("Invalid number of lectures.");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }

            private set
            {
                if (this.numberOfExercises < 0)
                {
                    throw new ArgumentException("Invalid number of exercises.");
                }

                this.numberOfExercises = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Disciplines: {0}", this.Name);
        }
    }
}
