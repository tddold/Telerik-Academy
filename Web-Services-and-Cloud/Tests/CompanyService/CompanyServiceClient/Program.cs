namespace CompanyServiceCl
{
    using System;
    using CompanyServiceCl.CompanyService;

    class Program
    {
        static void Main()
        {
            var client = new CompanyServiceClient();

            client.GetEmployeeInfoAsync(1).ContinueWith(
                (employeeResult) =>
                    {
                        var employeeAsync = employeeResult.Result;
                        Console.WriteLine("{0} -> {1}", employeeAsync.name, employeeAsync.Department);
                    });

            Console.WriteLine("working...");
            Console.ReadLine();

            //var employee = client.GetEmployeeInfo(1);
            //Console.WriteLine("{0} -> {1}", employee.name, employee.Department);
        }
    }
}
