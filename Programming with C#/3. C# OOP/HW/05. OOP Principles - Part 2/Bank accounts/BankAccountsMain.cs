/*Problem 2. Bank accounts
 * A bank holds different types of accounts for its customers: deposit accounts, loan accounts and 
 * mortgage accounts. Customers could be individuals or companies.
 * All accounts have customer, balance and interest rate (monthly based).
 * Deposit accounts are allowed to deposit and with draw money.
 * Loan and mortgage accounts can only deposit money.
 * All accounts can calculate their interest amount for a given period (in months). In the common case
 * its is calculated as follows: number_of_months * interest_rate.
 * Loan accounts have no interest for the first 3 months if are held by individuals and for the first 
 * 2 months if are held by a company.
 * Deposit accounts have no interest if their balance is positive and less than 1000.
 * Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the 
 * first 6 months for individuals.
 * Your task is to write a program to model the bank system by classes and interfaces.
 * You should identify the classes, interfaces, base classes and abstract actions and implement the 
 * calculation of the interest functionality through overridden methods.*/

namespace Bank_accounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BankAccountsMain
    {
        public const int NumberOfAcc = 3;

        public static void Main()
        {
            Console.WriteLine("Problem 2. Bank accounts");
            PrintSeparateLine();

            List<Custumer> custumersList = new List<Custumer>();

            // add idividual account
            for (int i = 0; i < NumberOfAcc; i++)
            {
                custumersList.Add(new IndividualAccount("IdividualAcc" + i));
            }

            // add company account
            for (int i = 0; i < NumberOfAcc; i++)
            {
                custumersList.Add(new CompanyAccount("CompanyAccount" + i));
            }

            List<Account> accountList = new List<Account>();

            accountList.Add(new DepositAccount(custumersList[0], 10, 900));
            accountList.Add(new DepositAccount(custumersList[1], 20, 1500));
            accountList.Add(new DepositAccount(custumersList[2], 20, 2000));
            accountList.Add(new LoanAccount(custumersList[3], 15, 1500));
            accountList.Add(new LoanAccount(custumersList[4], 15, 1500));
            accountList.Add(new MortgageAccount(custumersList[5], 10, 15000));

            foreach (var account in accountList)
            {
                // Console.WriteLine(account.Custumer.Name);
                Console.WriteLine("Calculate interest for 10mounth = {0}\n", account.CalculateInterest(10));
                account.Deposit(2000);

                if (account is DepositAccount)
                {
                    Console.WriteLine("Balance befor draw: {0} lv", account.Balance);

                    int drawMoney = 100;
                    account.Withdraw(drawMoney);

                    Console.WriteLine("I drow: {0} lv", drawMoney);

                    Console.WriteLine("Balance after draw: {0} lv", account.Balance);
                }
                else
                {
                    Console.WriteLine("I can't withdraw money!");
                    Console.WriteLine("Balance : {0} lv", account.Balance);
                }

                PrintSeparateLine();
            }
        }

        private static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
