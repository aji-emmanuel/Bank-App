using System;

namespace Models
{
    /// <summary>
    /// Contains User's Bank Account details
    /// </summary>

    public class BankAccountModel
    {
        //public uint Id { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }
        public string AccountName { get; set; }
        public ulong AccountNumber { get; set; }
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

        public BankAccountModel(/*uint id, */string password, string accountType, string accountName, ulong accountNumber, double accountBalance)
        {
            //Id = id;
            Password = password;
            AccountType = accountType;
            AccountName = accountName;
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
        }
    }
}
