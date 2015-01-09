/*Problem 10. Employee Data
A marketing company wants to keep record of its employees. Each record would have the following characteristics:
. First name
. Last name
. Age (0...100)
. Gender (m or f)
. Personal ID number (e.g. 8306112507)
. Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.*/

using System;

class EmployeeData
{
    static void Main()
    {
        Console.Title = "Employee Data";

        Console.WriteLine("Input employee data:");
        Console.WriteLine();

        Console.Write("Enter first name: ");
        string first = Console.ReadLine();

        Console.Write("Enter last name: ");
        string last = Console.ReadLine();

        Console.Write("Enter your age (between 0-100): ");
        byte age = byte.Parse(Console.ReadLine());

        if (age < 0 || age > 100)
        {
            Console.Write("Enter your age (between 0-100): ");
            age = byte.Parse(Console.ReadLine());
        }

        Console.Write("Enter your gender (m or f): ");
        char gender = char.Parse(Console.ReadLine());

        while (gender != 'm')
        {
            while (gender != 'f')
            {
                Console.Write("Enter your gender (m or f): ");
                gender = char.Parse(Console.ReadLine());
            }
            break;
        }

        Console.Write("Enter your personalID (between 8000000000 - 8999999999): ");
        ulong personalId = ulong.Parse(Console.ReadLine());

        while (personalId < 8000000000 || personalId > 8999999999)
        {
            Console.Write("Enter your personalID (between 8000000000 - 8999999999): ");

            personalId = ulong.Parse(Console.ReadLine());
        }

        Console.Write("Enter your employee number (between 27560000 - 27569999): ");
        uint employeeNumber = uint.Parse(Console.ReadLine());

        while (employeeNumber < 27560000 || employeeNumber > 27569999)
        {
            Console.Write("Enter your employee number (between 27560000 - 27569999): ");
            employeeNumber = uint.Parse(Console.ReadLine());
        }

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Employee Data is:");
        Console.WriteLine();
        Console.WriteLine("First name: " + first);
        Console.WriteLine("Last name: " + last);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Personal ID number: " + personalId);
        Console.WriteLine("Unique employee number: " + employeeNumber);
    }
}