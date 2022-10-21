using System.Text.Json;
using BankAppWinForms.Data.implementation;
using BankAppWinForms.Data.Interface;
using BankAppWinForms.Model.Entities;
using BankAppWinForms.Repositories.Interfaces;

namespace BankAppWinForms.Repositories.Implementations
{
    public class CustomerTransactionRepository:ICustormerTransactionRepository
    {
        private readonly IDatabase _database;
        public CustomerTransactionRepository(IDatabase database)
        {
            _database = database;
        }

        public void AddTransaction(CustomerTransaction model)
        {
            var total = _database.CustomerTransactions.Count;
            model.Id = total + 1;
            _database.CustomerTransactions.Add(model);
        }

        public ICollection<CustomerTransaction> GetTransactionsByAccountId(int accountId)
        {
            return _database.CustomerTransactions.Where(x => x.AccountId == accountId).ToList();
        }
    }


}
