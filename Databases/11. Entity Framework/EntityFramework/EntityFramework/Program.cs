namespace EntityFrameworkModel
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            // 1.Using the Visual Studio Entity Framework designer create a DbContext for the Northwind database
            // 2.Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers.
            // Write a testing class.

            string newCustomerId = "IVAIV";

            newCustomerId = CreateNewCustomer(newCustomerId, "Dell", "Ivan Ivanov");
            Console.WriteLine("Created new customer with Id:{0}", newCustomerId);

            ModifyCustomerName(newCustomerId, "Lenovo", "Jack Ma");
            Console.WriteLine("Modified the customer with ID {0}:", newCustomerId);


            Console.WriteLine("Deleted the customer with ID {0}:", newCustomerId);
            DeleteCustomer(newCustomerId);


            // 3.Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
            Console.WriteLine(new string('-', 35));
            FindAllCustomersWithOrdersFrom1997();


            // 4.Implement previous by using native SQL query and executing it through the DbContext.
            Console.WriteLine(new string('-', 35));
            FindAllCustomersWithOrdersFrom1997UsingSQL();

            // 5.Write a method that finds all the sales by specified region and period (start / end dates).
            Console.WriteLine(new string('-', 35));
            FindAllSalesBySpecifiedRegionAndPeriod("RJ", new DateTime(1998, 01, 01), new DateTime(1999, 05, 31));

        }

        private static void FindAllSalesBySpecifiedRegionAndPeriod(string region, DateTime startDate, DateTime endDate)
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                var sales = northwindEntities
                    .Order_Details
                    .Where(or => or.Order.ShipRegion == region)
                    .Where(or => or.Order.OrderDate == startDate)
                    .Where(or => or.Order.OrderDate == endDate)
                    .Select(c => new
                    {
                        Customer = c.Order.Customer.CompanyName,
                        Date = c.Order.OrderDate,
                        Product = c.Product.ProductName
                    });

                foreach (var item in sales)
                {
                    Console.WriteLine("Customer:{0} , OrderDate:{1}, Product:{2}", item.Customer, item.Date, item.Product);
                }
            }
        }

        private static void FindAllCustomersWithOrdersFrom1997UsingSQL()
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                string nativeSqlQuery =
                  @"SELECT * FROM dbo.Orders o
                    JOIN dbo.Customers c
                    ON o.CustomerID = c.CustomerID
                    WHERE (OrderDate BETWEEN '1997.01.01' AND '1997.12.31')
                    AND ShipCountry = 'Canada'
                    ORDER BY c.CompanyName";

                var customers = northwindEntities
                    .Database.SqlQuery<OrdeeToCanada>(nativeSqlQuery);

                foreach (var item in customers)
                {
                    Console.WriteLine(string.Format("Company: {0}, CompanyContact: {1}", item.CompanyName, item.ContactName));
                }
            }
        }

        private static void FindAllCustomersWithOrdersFrom1997()
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                var customers = northwindEntities
                    .Orders
                    .Where(or => or.ShipCountry == "Canada")
                    .Where(or => or.OrderDate >= new DateTime(1997, 01, 01))
                    .Where(or => or.OrderDate <= new DateTime(1997, 12, 31))
                    .OrderBy(or => or.Customer.CompanyName)
                    .Select(e => new
                    {
                        Company = e.Customer.CompanyName,
                        ContactName = e.Customer.ContactName,
                        Country = e.Customer.Country
                    })
                    .ToList();

                foreach (var item in customers)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void DeleteCustomer(string customerId)
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                Customer customer = GetCustomerById(northwindEntities, customerId);

                northwindEntities.Customers.Remove(customer);
                northwindEntities.SaveChanges();
            }
        }

        private static void ModifyCustomerName(string customerId, string companyName, string contactName)
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                Customer customer = GetCustomerById(northwindEntities, customerId);

                customer.CompanyName = companyName;
                customer.ContactName = contactName;
                northwindEntities.SaveChanges();
            }
        }

        private static Customer GetCustomerById(NorthwindEntities northwindEntities, string customerId)
        {
            Customer customer = northwindEntities
               .Customers
               .FirstOrDefault(p => p.CustomerID == customerId);

            return customer;
        }

        private static string CreateNewCustomer(string customerId, string companyName, string contactName)
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                Customer newCustomer = new Customer
                {
                    CustomerID = customerId,
                    CompanyName = companyName,
                    ContactName = contactName
                };

                northwindEntities.Customers.Add(newCustomer);
                northwindEntities.SaveChanges();
                return newCustomer.CustomerID;
            }
        }
    }
}
