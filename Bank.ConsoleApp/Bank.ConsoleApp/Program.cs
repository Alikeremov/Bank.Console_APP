using Bank.ConsoleApp.Models;
using Bank.ConsoleApp.Utilites.Exceptions;

namespace Bank.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BANK bank = new BANK();
            Account account = new Account();
            Account account2 = new Account();
            bank.CreateAccount(account);
            bank.CreateAccount(account2);
            bank.DepositMoney(1, 10000m);
            bank.WithdrawMoney(1, 100m);
            bank.WithdrawMoney(1, 1m);
            bank.TransferMoney(1, 2, 1m);
            bank.GetAllAccounts();


        }
    }
}