using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    /// <summary>
    /// Transaction Repository for saving of User's Transaction Details
    /// </summary>

    public class Transactions
    {
        public static List<TransactionModel> TransactionStorage = new List<TransactionModel>();

        /// <summary>
        /// Saves a given transaction to transaction repository
        /// </summary>
        /// <param name="user"></param>

        public void AddTransaction(TransactionModel user)
        {
            TransactionStorage.Add(user);
        }

        /// <summary>
        /// Extracts the Transaction Details of an Account that's logged in.
        /// </summary>
        /// <param name="loggedAccNo"></param>
        /// <returns></returns>

        public static List<TransactionModel> GetLoggedAccountTransactions(string loggedAccNo)
        {
            List<TransactionModel> loggedAccounts = new List<TransactionModel>();
            foreach (var item in TransactionStorage)
            {
                if (item.AccountNumber == loggedAccNo)
                {
                    loggedAccounts.Add(item);
                }
            }
            return loggedAccounts;
        }
    }
}
