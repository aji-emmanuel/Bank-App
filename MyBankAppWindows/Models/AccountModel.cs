using System;

namespace Models
{
    /// <summary>
    /// Contains User's Bank Account details
    /// </summary>

    public class AccountModel
    {
        public string AccountType { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public double AccountBalance { get; set; }

        /// <summary>
        /// Retrieves User's Bank Account Details
        /// </summary>
        /// <param name="id"></param>
        /// <param name="password"></param>
        /// <param name="accountType"></param>
        /// <param name="accountName"></param>
        /// <param name="accountNumber"></param>
        /// <param name="accountBalance"></param>

        public AccountModel(string accountName, string accountNumber, string accountType, double accountBalance)
        {
            AccountName = accountName;
            AccountNumber = accountNumber;
            AccountType = accountType;
            AccountBalance = accountBalance;
        }
    }
}
