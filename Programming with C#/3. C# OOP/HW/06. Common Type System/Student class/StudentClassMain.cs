/*Problem 1. Student class
 * Define a class Student, which contains data about a student – first, middle and last name, SSN, 
 * permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration 
 * for the specialties, universities and faculties.
 * Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and 
 * operators == and !=.*/

namespace Student_class
{
    using System;
    using System.Net.Mail;

    public class StudentClassMain
    {
        public static void Main()
        {
            Console.WriteLine("Problem 1. Student class");
            PrintSeparateLine();

            var student = new Student("Ivan", "Ivanov", "Ivanov", 10100123, "Sofia, ul.Al. Malinov 22", "+359123456", new MailAddress("ivanov@abv.bg"), "1a", Specialty.ComputerScience, University.SofiaUneversity, Faculty.MathematicsAndInformatics);

            Console.WriteLine("Override ToString():\n");
            Console.WriteLine(student);
                        
            Console.WriteLine("Override GetHashCode(): {0}", student.GetHashCode());
            PrintSeparateLine();

            var newStudent = student.Clone();

            Console.WriteLine("\nClone student:\n");
            Console.WriteLine(newStudent);
            PrintSeparateLine();
        }

        private static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
