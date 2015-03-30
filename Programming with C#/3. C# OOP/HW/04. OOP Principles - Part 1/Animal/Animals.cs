namespace Animal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Animals : ISound
    {
        private int age;
        private string name;
        private string sex;

        public Animals(int age, string name, string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public int Age
        {
            get { return this.age; }

            set { this.age = value; }
        }

        public string Name
        {
            get { return this.name; }

            set { this.name = value; }
        }

        public string Sex
        {
            get { return this.sex; }

            set { this.sex = value; }
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Mrrrrr");
        }
    }
}
