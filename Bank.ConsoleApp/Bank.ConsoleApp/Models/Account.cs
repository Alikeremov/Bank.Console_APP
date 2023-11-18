using Bank.ConsoleApp.Utilites.Exceptions;
using Bank.ConsoleApp.Utilites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ConsoleApp.Models
{
    internal class Account : IAccount
    {
        static int _count;
        public List<Transaction> transactions = new List<Transaction>();
        public int AccountId { get; }
        public decimal Balance { get; set; } = 0;

        public void Deposit(decimal amount)
        {
            if(amount>0)
            {
                Balance += amount;
                Transaction transaction = new Transaction(Balance, "Deposit");
                transactions.Add(transaction);
                Console.WriteLine(transaction);
            }
            else
            {
                throw new InsufficientFundsException("You can't pay this value");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (Balance < amount || amount==0)
            {
                throw new InsufficientFundsException("You can't pay this value");
            }
            Balance -=amount;
            Transaction transaction = new Transaction(Balance, "Withdraw");
            transactions.Add(transaction);
            Console.WriteLine(transaction);
        }
        public Account(int balance = 0)
        {
            _count++;
            Balance = balance;
            AccountId= _count;
        }
        public override string ToString()
        {
            return $"AccountID:{AccountId} Balance:{Balance}";
        }
    }
}
