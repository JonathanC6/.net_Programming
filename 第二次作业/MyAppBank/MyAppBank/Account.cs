using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppBank
{
    internal class Account
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; protected set; }

        public Account(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        //存钱
        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposit: {amount}. New Balance: {Balance}");
        }

        //取钱
        public virtual void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw: {amount}. New Balance: {Balance}");
            }
        }
    }

    internal class CreditAccount : Account
    {
        public decimal CreditLimit { get; private set; }

        public CreditAccount(string accountNumber, decimal initialBalance, decimal creditLimit) : base(accountNumber, initialBalance)
        {
            CreditLimit = creditLimit;
        }

        public override void Deposit(decimal amount)
        {
            base.Deposit(amount);
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > Balance + CreditLimit)
            {
                Console.WriteLine("Exceeds credit limit.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw (Credit Account): {amount}. New Balance: {Balance}");
            }
        }
    }
}
