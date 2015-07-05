namespace MakePerson
{
    using System;

    public class Person
    {
        private string name;
        private int age;
        private Gender gender;

        public Person()
        {
        }

        public Person(string name, int age, Gender gender) :
            this()
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid name!");
                }

                this.name = value;
            }
        }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public override string ToString()
        {
            return string.Format("The person name is: {0}, age: {1}, sex: {2}", this.Name, this.Age, this.Gender);
        }
    }
}
