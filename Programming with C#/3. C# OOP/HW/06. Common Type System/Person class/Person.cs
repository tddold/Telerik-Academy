namespace Person_class
{
    using System;
    using System.Text;

    public class Person
    {
        private string name;
        private uint age;

        public Person(string name, uint age = 0)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }

            private set { this.name = value; }
        }

        public uint Age
        {
            get { return this.age; }

            private set { this.age = value; }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(string.Format("Name: {0}", this.Name));

            if (Age != 0)
            {
                sb.AppendLine(string.Format("Age: {0}", this.Age));
            }
            else
            {
                sb.AppendLine("You havent set any value for the age of the person, so the age is null !!!");
            }

            return sb.ToString();
        }
    }
}
