/*Problem 4. Person class
Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
Write a program to test this functionality.*/

namespace Person_class
{
    using System;

    class PersonClassMain
    {
        static void Main()
        {
            Console.WriteLine("Problem 4. Person class");
            PrintSeparateLine();

            var person = new Person("Pesho Peshev");

            Console.WriteLine(person);
            PrintSeparateLine();

            var newPerson = new Person("Ivan Ivanov", 26);

            Console.WriteLine(newPerson);
            PrintSeparateLine();
        }

        private static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
