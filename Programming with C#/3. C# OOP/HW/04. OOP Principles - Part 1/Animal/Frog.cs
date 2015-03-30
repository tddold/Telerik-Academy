namespace Animal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Frog : Animals
    {
        public Frog(int age, string name, string sex)
            : base(age, name, sex)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Frog say Kva Kva....");
        }
    }
}
