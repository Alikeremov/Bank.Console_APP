using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ConsoleApp.Models
{
    internal class Transaction
    {
        static int Count;
        private int TransactionId { get;  }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public Transaction(decimal amount,string transactiontype)
        {
            Count++;
            Amount=amount;
            TransactionType = transactiontype;
            TransactionDate=DateTime.Now;
            TransactionId = Count;
        }
        public override string ToString()
        {
            return $"Amount:{Amount} TransactionType:{TransactionType} TransactionDate:{TransactionDate} TransactionId:{TransactionId}";
            
        }
    }
}
