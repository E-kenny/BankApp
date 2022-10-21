
using BankAppWinForms.Model.Entities;
using System.Transactions;

namespace BankAppWinForms.Repositories.Interfaces
{
    public interface ICustormerTransactionRepository
    {
        void AddTransaction(CustomerTransaction model);
        ICollection<CustomerTransaction> GetTransactionsByAccountId(int accountId);


    }

}
