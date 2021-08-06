using Models;
using SQLQueries;
using System;

namespace Operations
{
    public class TransactionOperation
    {
        /// <summary>
        /// Saves Debit Transaction details
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="amount"></param>
        /// <param name="description"></param>
        /// <returns></returns>

        public bool DebitTransaction(string accountNumber, string amount, string description, decimal newBalance)
        {
            if (description == "")
            {
                description = "Debit";
            }
            TransactionModel debit = new TransactionModel(accountNumber, DateTime.Now.ToString(), description, amount + "Dr", newBalance);
            bool success = TransactionQueries.AddTransaction(debit);
            TransactionQueries.UpdateAccountBalance(debit);
            return success;
        }

        /// <summary>
        /// Saves Credit Transaction details
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="amount"></param>
        /// <param name="description"></param>
        /// <returns></returns>

        public bool CreditTransaction(string accountNumber, string amount, string description, decimal newBalance)
        {
            if(description=="")
            {
                description = "Credit";
            }
            TransactionModel credit = new TransactionModel(accountNumber, DateTime.Now.ToString(), description, amount +"Cr",  newBalance);
            bool success = TransactionQueries.AddTransaction(credit);
            TransactionQueries.UpdateAccountBalance(credit);
            return success;
        }
    }
}
