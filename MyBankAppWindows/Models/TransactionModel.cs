namespace Models
{
    /// <summary>
    /// Contains User's Transaction details
    /// </summary>

    public class TransactionModel
    {
        public string Amount { get; set; }
        public string TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public string TransactionDescription { get; set; }
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }


        public TransactionModel(string accountNumber, string transactionDate, string transactionDescription, string amount, decimal accountBalance)
        {
            Amount = amount;
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
            TransactionDate = transactionDate;
            TransactionDescription = transactionDescription;
        }
    }
}
