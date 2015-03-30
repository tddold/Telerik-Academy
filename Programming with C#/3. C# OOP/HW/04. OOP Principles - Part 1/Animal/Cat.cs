namespace Animal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Cat : Animals
    {
        private string sex;        

        public Cat(int age, string name, string sex)
            : base(age, name, sex)
        {

        }

        public new string Sex
        {
            get { return this.sex; }
            private set { this.sex = value; }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cat say Miauuu...");
        }
    }
}
