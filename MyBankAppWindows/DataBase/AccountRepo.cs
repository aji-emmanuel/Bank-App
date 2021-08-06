using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataBase
{
    /// <summary>
    /// Account Repository for saving of User's Account Details
    /// </summary>

    public class BankAccount
    {
        public static List<AccountModel> accountList = new List<AccountModel>();
        static readonly string fileLocation = "userAccount-details.txt";

        /// <summary>
        /// Saves the account details of a new user
        /// </summary>
        /// <param name="user"></param>

        public void AddAccount(string accountName, string accountNo, string accountType, double accountBalance)
        {
            AccountModel newAccount = new AccountModel(accountName, accountNo, accountType, accountBalance);
            accountList.Add(newAccount);
            SaveAccountDetails(newAccount);
        }

        /// <summary>
        /// Gets the Account Details of a Logged User
        /// </summary>
        /// <param name="loggedAccName"></param>
        /// <returns></returns>

        public static List<string> GetLoggedAccount (string loggedAccName/*, string email*/)
        {
            List<string> loggedAccounts = new List<string>();
            foreach(var item in accountList)
            {
                if(item.AccountName== loggedAccName)
                {
                    loggedAccounts.Add(item.AccountNumber);
                }
            }
            return loggedAccounts;
        }

        /// <summary>
        /// Iterates through the Account repository to get the account number of a user
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>

        public static AccountModel GetByAccountNumber(string accountNumber)
        {
            return accountList.FirstOrDefault(accnt => accnt.AccountNumber == accountNumber);
        }

        public static string GetByAccountType(string accountNumber)
        {
           AccountModel list = accountList.FirstOrDefault(accnt => accnt.AccountNumber == accountNumber);
           return list.AccountType;
        }


        public static void LoadAccountDetails()
        {
            if (File.Exists(fileLocation))
            {
                string[] lines = File.ReadAllLines(fileLocation);
                foreach (string line in lines)
                {
                    string accountName = line.Substring(0).Split(',')[0];
                    string accountNo = line.Substring(0).Split(',')[1];
                    string accountType = line.Substring(0).Split(',')[2];
                    double accountBalance = Convert.ToDouble(line.Substring(0).Split(',')[3]);

                    AccountModel user = new AccountModel(accountName, accountNo, accountType, accountBalance);
                    accountList.Add(user);
                }
            }
        }

        void SaveAccountDetails(AccountModel user)
        {
            List<string> allUsers = new List<string>
            {
                $"{user.AccountName},{user.AccountNumber},{user.AccountType},{user.AccountBalance}"
            };
            File.AppendAllLines(fileLocation, allUsers);
        }
    }
}
