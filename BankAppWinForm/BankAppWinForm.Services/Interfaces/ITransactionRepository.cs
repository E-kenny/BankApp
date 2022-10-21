using BankAppWinForm.Models;
using System.IO;
using System.Text.Json;

namespace BankAppWinForm.Repositories.Interfaces
{
    public interface ITransactionRepository
    {
        List<CustomerTransaction> ReadAllTransactions();
        void WriteAllTransactions(List<CustomerTransaction> data);

    }
}
