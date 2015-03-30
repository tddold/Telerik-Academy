namespace Animal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Kitten : Cat
    {
        //private string sex;

        public Kitten(int age, string name)
            : base(age, name, "Female")
        {

        }
       
        //public string Sex
        //{
        //    get{return this.sex;}
        //}

        public override void MakeSound()
        {
            Console.WriteLine("Kitten say Miau Miau Miau");
        }
    }
}
