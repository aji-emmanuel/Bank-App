using Models;
using SQLQueries;
using System;

namespace Operations
{
    /// <summary>
    /// Contains the various methods that carries out the various Account Trasactions
    /// </summary>

    public class AccountOperations
    {
        /// <summary>
        /// Returns a bool if deposit is successful.
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="description"></param>
        /// <param name="amount"></param>
        /// <returns></returns>

        public bool Deposit(string accountNumber, string description, decimal amount)
        {
            Account account = AccountQueries.GetAccountDetails(accountNumber);
            account.AccountBalance += amount;
            bool success = CreditTransaction(accountNumber, amount.ToString(), description, account.AccountBalance);
            return success;
        }

        /// <summary>
        /// Returns a bool if withdrawal is successful.
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="amount"></param>

        public bool Withdraw(string accountNumber, string description, decimal amount)
        {
            Account account = AccountQueries.GetAccountDetails(accountNumber);
            decimal minBalance = account.AccountType == "Savings" ? 1000.0M : 0.0M;

            if (amount <= account.AccountBalance - minBalance)
            {
                account.AccountBalance -= amount;
                bool success = DebitTransaction(accountNumber, amount.ToString(), description, account.AccountBalance);
                return success;
            }
            else
                return false;
        }

        /// <summary>
        /// Returns a bool if transfer is successful.
        /// </summary>
        /// <param name="senderAccountNumber"></param>
        /// <param name="receiverAccountNumber"></param>
        /// <param name="description"></param>
        /// <param name="amount"></param>
        /// <returns></returns>

        public bool Transfer(string senderAccountNumber, string receiverAccountNumber, string description, decimal amount)
        {
            bool success = Withdraw(senderAccountNumber, description, amount);
            if (success)
            {
                bool success1 = Deposit(receiverAccountNumber, description, amount);
                return success1;
            }
            return false;
        }

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
            if (description == "")
            {
                description = "Credit";
            }
            TransactionModel credit = new TransactionModel(accountNumber, DateTime.Now.ToString(), description, amount + "Cr", newBalance);
            bool success = TransactionQueries.AddTransaction(credit);
            TransactionQueries.UpdateAccountBalance(credit);
            return success;
        }
    }
}
