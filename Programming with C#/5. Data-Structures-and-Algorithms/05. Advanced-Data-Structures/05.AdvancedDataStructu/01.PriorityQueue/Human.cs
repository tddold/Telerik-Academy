namespace _01.PriorityQueue
{
    using System;

    public class Human : IComparable
    {
        public Human(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            var other = obj as Human;

            if (ReferenceEquals(other, null))
            {
                return -1;
            }

            var compararionByAge = this.Age.CompareTo(other.Age);

            return compararionByAge;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", this.Name, this.Age);
        }

    }
}
