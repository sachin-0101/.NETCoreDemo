using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_AccessModifier
{
    using System;
    using System.Security.Principal;

    public class BankAccount
    {
        // Fields
        private string accountNumber;    // Private: sensitive info
        private decimal balance;         // Private: only accessible through methods
        private string ownerName;        // Private: internal to the class

        // Constructor
        public BankAccount(string accountNumber, string ownerName, decimal initialBalance = 0)
        {
            this.accountNumber = accountNumber;
            this.ownerName = ownerName;
            balance = initialBalance;
        }

        // Public getter for account number (read-only)
        public string AccountNumber => accountNumber;

        // Public getter for owner name (read-only)
        public string OwnerName => ownerName;

        // Public getter for balance (read-only)
        public decimal Balance => balance;

        // Deposit method
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }

            balance += amount;
        }

        // Withdraw method
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }

            if (amount > balance)
            {
                return false; // Insufficient funds
            }

            balance -= amount;
            return true;
        }

        // Display account info (optional)
        public void PrintAccountSummary()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("*****Bank Account Summary*****\n");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Owner Name: {OwnerName}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine("------------------------------------");
        }
    }

}
