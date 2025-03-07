using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    class BankAccount
    {
        private readonly string _accountNumber; // cannot be modified after initialization
        private string _accountHolder;
        private decimal _balance;

        // Constructor
        public BankAccount(string accountNumber, string accountHolder, decimal initialBalance)
        {
            this._accountNumber = accountNumber;
            this._accountHolder = accountHolder;
            _balance = initialBalance > 0 ? initialBalance : throw new ArgumentException("Initial Balance must be positive");
        }

        // Encapsulated property with validation
        public string AccountHolder
        {
            get => _accountHolder;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Account holder name cannot be empty.");
                _accountHolder = value;
            }
        }

        // Read-Only property
        public string AccountNumber => _accountNumber;

        // Read-Only balance property (no public setter)
        public decimal Balance => _balance;

        // Encapsulated method for deposit
        public void Deposit(decimal amount)
        {
            if (amount==0)
                throw new ArgumentException("Deposit amount must be positive.");
            _balance += amount;
            Console.WriteLine($"Deposited : {amount:C}, New Balance : {_balance:C}");
        }

        // Encapsulated method for deposit
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive.");

            if (amount > _balance)
            {
                Console.WriteLine("Insufficient Balance.");
                return false;
            }
            _balance -= amount;
            Console.WriteLine($"Withdrawn : {amount:C} remaining balance : {_balance:C}");
            return true;
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number : {AccountNumber} \nAccount Holder : {AccountHolder} \nBalance : {Balance}");
        }
    }
}
