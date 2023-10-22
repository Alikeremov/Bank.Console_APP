using Bank.ConsoleApp.Utilites.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ConsoleApp.Models
{
    internal class BANK
    {
        public List<Account> Accounts = new List<Account> { };

        public void CreateAccount(Account account)
        {
            Accounts.Add(account);
            Console.WriteLine("Account created is succesfull");
            Console.WriteLine($"Your Account ID is {account.AccountId}");
        }
        public void DepositMoney(int accountId, decimal amount)
        {
            bool result = false;
            foreach (Account account in Accounts)
            {
                if(account.AccountId == accountId)
                {
                    account.Deposit(amount);
                    result = true;
                }
            }
            if(!result)
            {
                throw new AccountNotFoundException("Account is not found");
            }
        }
        public void WithdrawMoney(int accountId,decimal amount)
        {
            bool result=false;
            foreach (Account account in Accounts)
            {
                if(account.AccountId == accountId)
                {
                    account.Withdraw(amount);
                    result = true;
                }
            }
            if (!result)
            {
                throw new AccountNotFoundException("Account is not found");
            }
        }
        public void TransferMoney(int fromAccountId, int toAccountId,decimal amount)
        {
            int num = 0;
            int num2 = 0;
            int count = 0;
            bool result = false;
            foreach (Account account in Accounts)
            {
                if(account.AccountId == fromAccountId)
                {
                    count++;
                    num = account.AccountId-1;
                }
                else if (account.AccountId == toAccountId)
                {
                    count++;
                    num2= account.AccountId-1;
                }
                
            }
            if (count==2)
            {
                Accounts[num].Withdraw(amount);
                Accounts[num2].Deposit(amount);
                result=true;
            }
            else
            {
                Console.WriteLine("Transfer was failed");
            }
            if (!result)
            {
                throw new AccountNotFoundException("Account is not found");
            }
        }
        public void GetAllAccounts()
        {
            foreach(Account account in Accounts)
            {
                Console.WriteLine(account);
            }
        }
    }
}