namespace Animal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Tomcat : Cat
    {
        //private string sex;

        public Tomcat(int age, string name)
            : base(age, name, "Male")
        {

        }

        //public string Sex
        //{
        //    get { return this.sex; }
        //}

        public override void MakeSound()
        {
            Console.WriteLine("Tomcat say Miauu Miauu Miauu");
        }
    }
}
