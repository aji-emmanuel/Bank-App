using Models;
using SQLQueries;

namespace Operations
{
    /// <summary>
    /// Contains the various methods that carries out the various Account Trasactions
    /// </summary>

    public class AccountOperations
    {
        /// <summary>
        /// Returns -1 if deposit is unsuccessful or a newBalance if deposit is successful
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="amount"></param>

        public decimal Deposit(string accountNumber, decimal amount)
        {
            decimal newBalance = -1;
            Account account = AccountQueries.GetAccountDetails(accountNumber);

            if (account == null)
            {
                return newBalance;
            }
            newBalance = account.AccountBalance + amount;
            return newBalance;
        }

        /// <summary>
        /// Returns -1 if amount is greater than Account Balance or newBalance if withdrawal is successful
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="amount"></param>

        public decimal Withdraw(string accountNumber, decimal amount)
        {
            decimal newBalance = -1;
            Account account = AccountQueries.GetAccountDetails(accountNumber);

            if (account.AccountType == "Savings")
            {
                if (amount > account.AccountBalance - 1000M)
                {
                    return newBalance;
                }
                else
                {
                    newBalance = account.AccountBalance - amount;
                    return newBalance;
                }
            }
            else
            {
                if (amount > account.AccountBalance)
                {
                    return newBalance;
                }
                else
                {
                    newBalance = account.AccountBalance - amount;
                    return newBalance;
                }
            }
        }

        /// <summary>
        /// Subtracts the transferred amount from the sender's Account and Adds it to the Receivers Account
        /// </summary>
        /// <param name="senderAccountNumber"></param>
        /// <param name="receiverAccountNumber"></param>
        /// <param name="amount"></param>
        /// <returns></returns>

        public bool Transfer(string senderAccountNumber, string receiverAccountNumber, decimal amount)
        {
            if (Withdraw(senderAccountNumber, amount)!=-1)
            {
                Deposit(receiverAccountNumber, amount);
                return true;
            }
            return false;
        }
    }
}
