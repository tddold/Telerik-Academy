
#Facade
1.	Цел на шаблона  - предоставяне на интерфейс за достъп до сложна системата от класове.
2.	Структура:
 
<p align="center"><a href="https://github.com/tddold/Telerik-Academy/blob/master/Programming%20with%20C%23/4.%20High-Quality-Code/HW/17.%20Design%20Patterns/Homework/Picture/Facade.png"><img src="https://github.com/tddold/Telerik-Academy/blob/master/Programming%20with%20C%23/4.%20High-Quality-Code/HW/17.%20Design%20Patterns/Homework/Picture/Facade.png" /></a></p>

3.	Приложения: - Уеб услугите (web services) могат да се разглеждат като реализация на фасада, когато нямат собствена бизнес логика, а са дефинирани за предоставяне на достъп до дадена система.
4.	Свързани шаблони – “Abstract Factory” и “Sigleton”
5.	
В модела фасада,  фасада е обект, който предвижда опростена интерфейс за по-голямо обединение на код, като например библиотека клас. A фасада може да:

направи софтуерна библиотека лесна за използване, разбират и тестове, тъй като фасадата има удобни методи за общи задачи;
прави библиотеката по-разбираеми, по същата причина;
намаляване на зависимостта на границата код на вътрешната изработки на библиотека, тъй като повечето код използва фасадата, което позволява по-голяма гъвкавост в разработването на системата;
увийте лошо проектирани колекция от APIs с едно добре проектирана API.
Дизайн модел на фасадата се използва често, когато една система е много сложна или трудна за разбиране, защото системата има голям брой взаимосвързани класове или изходен код не е на разположение. Този модел се крие сложността на по-голяма система и осигурява по-опростен интерфейс на клиента. Това обикновено включва един-единствен лист клас, който съдържа набор от членовете се изисква от клиента. Тези членове имат достъп до системата от името на клиента фасада и крият подробностите по изпълнението.

### Моделът на фасадата обикновено се използва, когато:

-   прост интерфейс се изисква за достъп до сложна система;
-   абстракциите и приложения на подсистема са тясно свързани;
-   нужда от входна точка към всяко ниво на пластова софтуер; или
-   система е много сложна или трудна за разбиране.

### Структура
Пример за дизайн Фасада модел в UML.png
<p align="center"><a href="https://github.com/tddold/Telerik-Academy/blob/master/Programming%20with%20C%23/4.%20High-Quality-Code/HW/17.%20Design%20Patterns/Homework/Picture/Facade.png"><img src="https://github.com/tddold/Telerik-Academy/blob/master/Programming%20with%20C%23/4.%20High-Quality-Code/HW/17.%20Design%20Patterns/Homework/Picture/Facade.png" /></a></p>

Пример
This is an abstract example of how a client ("you") interacts with a facade (the "computer") to a complex system (internal computer parts, like CPU and HardDrive).

Примерен код:
'''
namespace Facade.Example
{
    using System;

    /// <summary>
    /// MainApp startup
    /// Facade Design Pattern.
    /// </summary>
    public class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main()
        {
            // Facade
            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Pesho");

            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine();
            Console.WriteLine("{0} has been {1}", customer.Name, eligible ? "Approved" : "Rejected");
        }
    }
    
    /// <summary>
    /// Subsystem A
    /// </summary>
    internal class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for {0}", c.Name);

            return true;
        }
    }
    
    /// <summary>
    /// Subsystem B
    /// </summary>
    internal class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for {0}", c.Name);

            return true;
        }
    }
    
    /// <summary>
    /// Subsystem C
    /// </summary>
    internal class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);

            return true;
        }
    }
    
    /// <summary>
    /// Out customer class
    /// </summary>
    public class Customer
    {
        private string name;

        // Constructor
        public Customer(string name)
        {
            this.name = name;
        }

        // Gets the name
        public string Name
        {
            get
            {
                return this.name;
            }
        }
    }
    
    /// <summary>
    /// Our Facade class
    /// </summary>
    public class Mortgage
    {
        private Bank bank = new Bank();

        private Loan loan = new Loan();

        private Credit credit = new Credit();

        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine(
                "{0} applies for {1:C} loan\n",
                cust.Name, 
                amount);

            bool eligible = true;

            // Check creditworthyness of applicant
            if (!this.bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!this.loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!this.credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}

'''
