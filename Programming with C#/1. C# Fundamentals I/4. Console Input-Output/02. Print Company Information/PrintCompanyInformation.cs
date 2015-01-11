/*Problem 2. Print Company Information
A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.*/

using System;

    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Title = "Print Company Information";
                        
            Console.WriteLine("Print Company Information");
            Console.WriteLine(new string('-', 40));
            Console.Write("Company name: ");
            string name = Console.ReadLine();
            Console.Write("Company address: ");
            string address = Console.ReadLine();
            Console.Write("Phone number (10 digits): ");
            ulong tel = ulong.Parse(Console.ReadLine());
            
            Console.Write("Fax number: ");

            string fax = Console.ReadLine();

            if (fax != null && fax != "")
            {
            }
            else
            {
                fax = "(no fax)";
            }

            Console.Write("Web site: ");
            string web = Console.ReadLine();
            Console.Write("Manager first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Manager age: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.Write("Manager phone (7 digits): ");
            ulong telManger = ulong.Parse(Console.ReadLine());

            while (telManger < 0000000 || telManger > 9999999)
            {
                Console.Write("Phone number (7 digits): ");
                telManger = ulong.Parse(Console.ReadLine());
            }

            Console.WriteLine(new string('-', 40));
            Console.WriteLine("{0}\nAddress: {1}\nTel. {2:+359 ### ## ## ##}\nFax: {3}\nWeb site: {4}\nManager: {5} (age: {6}, tel. {7:+359 # ### ###)}", name, address, tel, fax, web, (firstName + " " + lastName), age, telManger);
        }
    }