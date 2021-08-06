using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    /// <summary>
    /// Transaction Repository for saving of User's Transaction Details
    /// </summary>

    public class Transaction
    {
        public List<TransactionModel> TransactionStorage = new List<TransactionModel>();

        /// <summary>
        /// Saves a given transaction to transaction repository
        /// </summary>
        /// <param name="user"></param>

        public void AddTransaction(TransactionModel user)
        {
            TransactionStorage.Add(user);
        }
    }
}
