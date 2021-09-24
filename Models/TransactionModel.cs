using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Contains User's Transaction details
    /// </summary>

    public class TransactionModel:BankAccountModel
    {
        public string Amount { get; set; }
        // public ulong AccountNumber { get; set; }
        public string TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public string TransactionDescription { get; set; }
        //public double AccountBalance { get; set; }

        /// <summary>
        /// Retrieves User's Transaction details
        /// </summary>
        /// <param name="id"></param>
        /// <param name="amount"></param>
        /// <param name="transactionDate"></param>
        /// <param name="transactionType"></param>
        /// <param name="transactionDescription"></param>

        public TransactionModel(string accountName, ulong accountNumber, string amount, string transactionDate, string transactionDescription, double accountBalance)
        {
            Amount = amount;
            AccountName = accountName;
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
            TransactionDate = transactionDate;
            TransactionDescription = transactionDescription;
        }
    }
}
