using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account
    {
        public string Owner { get; set; }
        public decimal Balance { get; private set; }

        public Account(string name, decimal initialBalance)
        {
            Owner = name;
            Balance = initialBalance;
        }

        // Method to deposit money into the account
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Successfully deposited ${amount}.");
            }
        }


        // Method to withdraw money from the account
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Successfully withdrew ${amount}.");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid amount.");
            }
        }





        static void Main(string[] args)
        {
            // Create a new account
            Console.WriteLine("Welcome to the C# Bank!");
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Account myAccount = new Account(userName, 100.00m); // Start with $100
            Console.WriteLine($"Hello {myAccount.Owner}, your starting balance is ${myAccount.Balance}");

            // Simple interaction
            Console.WriteLine("\nHow much would you like to deposit?");
            if (decimal.TryParse(Console.ReadLine(), out decimal depAmount))
            {
                myAccount.Deposit(depAmount);
            }

            Console.WriteLine($"Final Balance: ${myAccount.Balance}");

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}


