using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ConsoleApp.Utilites.Interfaces
{
    internal interface IAccount
    {
        int AccountId { get;  }
        decimal Balance { get; set; }
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        
    }
}
