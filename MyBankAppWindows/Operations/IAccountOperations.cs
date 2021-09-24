using System.Threading.Tasks;

namespace MyBankAppWindows.Operations
{
    public interface IAccountOperations
    {
        Task<bool> Deposit(string accountNumber, string description, decimal amount);
        Task<bool> Withdraw(string accountNumber, string description, decimal amount);
        Task<bool> Transfer(string senderAccountNumber, string receiverAccountNumber, string description, decimal amount);
    }
}
