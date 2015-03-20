/*Problem 9. Student groups
 * Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), 
 * GroupNumber.
 * Create a List<Student> with sample students. Select only the students that are from group 
 * number 2.
 * Use LINQ query. Order the students by FirstName.
 * Problem 10. Student groups extensions
 * Implement the previous using the same query expressed with extension methods.
 * Problem 11. Extract students by email
 * Extract all students that have email in abv.bg.
 * Use string methods and LINQ.
 * Problem 12. Extract students by phone
 * Extract all students with phones in Sofia.
 * Use LINQ.
 * Problem 13. Extract students by marks
 * Select all students that have at least one mark Excellent (6) into a new anonymous class that 
 * has properties – FullName and Marks.
 * Use LINQ.
 * Problem 14. Extract students with two marks
 * Write down a similar program that extracts the students with exactly two marks "2".
 * Use extension methods.
 * Problem 15. Extract marks
 * Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as 
 * their 5-th and 6-th digit in the FN).
 * Problem 16.* Groups
 * Create a class Group with properties GroupNumber and DepartmentName.
 * Introduce a property GroupNumber in the Student class.
 * Extract all students from "Mathematics" department.
 * Use the Join operator.*/

namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Net.Mail;

    class StudentMain
    {
        static void Main()
        {
            var students = new List<Student>()
            {
                new Student {FirstName = "Ivan",
                            LastName = "Ivanov",
                            FacultyNumber = "100101",
                            Phone = "+35988123456",
                            Email = new MailAddress ("ivan@abv.bg"),
                            Marks =  new List<int> { 1,2,3},
                            Group =  new Group("1", "Informatica")},
               new Student {FirstName = "Pesho",
                            LastName = "Peshev",
                            FacultyNumber = "100102",
                            Phone = "+35988123457",
                            Email = new MailAddress ("pesho@abv.bg"),
                            Marks =  new List<int> { 1,2,3},
                            Group =  new Group("2", "Informatica")},
            };

            Console.WriteLine(string.Join(", ", students));
        }
    }
}
