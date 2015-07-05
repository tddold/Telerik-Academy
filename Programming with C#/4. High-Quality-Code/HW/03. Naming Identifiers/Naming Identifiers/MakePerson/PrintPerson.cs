namespace MakePerson
{
    using System;

    public class PrintPerson
    {
        public static void Main()
        {
            CreatPerson(24);
            CreatPerson(15);
        }

        public static void CreatPerson(int age)
        {
            var person = new Person();
            person.Age = age;

            if (age % 2 == 0)
            {
                person.Name = "Pesho";
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "Mimi";
                person.Gender = Gender.Female;
            }

            Console.WriteLine(person);
        }
    }
}
