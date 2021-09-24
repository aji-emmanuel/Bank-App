using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataBase
{
    /// <summary>
    /// Account Repository for saving of User's Account Details
    /// </summary>

    public class BankAccount
    {
        private List<BankAccountModel> accountList = new List<BankAccountModel>();

        public List<BankAccountModel> AccountList { get => accountList; set => accountList = value; }

        /// <summary>
        /// Saves the account details of a new user
        /// </summary>
        /// <param name="user"></param>

        public void AddAccount(BankAccountModel user)
        {
            AccountList.Add(user);
        }

        /// <summary>
        /// Iterates through the Account repository to get the account number of a user
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>

        public BankAccountModel GetByAccountNumber(ulong accountNumber)
        {
            return AccountList.FirstOrDefault(accnt => accnt.AccountNumber == accountNumber);
        }
    }
}
