using System.Threading.Tasks;

namespace MyBankAppWindows.Operations
{
    public interface ITransactionOperations
    {
        Task<bool> DebitTransaction(string accountNumber, string amount, string description, decimal newBalance);
        Task<bool> CreditTransaction(string accountNumber, string amount, string description, decimal newBalance);
    }
}
