namespace Models
{
    /// <summary>
    /// Contains User's Bank Account details
    /// </summary>

    public class Account
    {
        public string AccountId { get; set; }
        public string AccountType { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }


        public Account(string accountId, string accountName, string accountNumber, string accountType, decimal accountBalance)
        {
            AccountId = accountId;
            AccountName = accountName;
            AccountNumber = accountNumber;
            AccountType = accountType;
            AccountBalance = accountBalance;
        }
    }
}
