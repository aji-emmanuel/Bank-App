using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Assigns names to the available Account type
    /// </summary>

    public enum AccountType
    {
        Savings, Current
    }

    /// <summary>
    /// Assigns names to the available Transaction type
    /// </summary>

    public enum TransactionType
    {
        Debit, Credit
    }
}
