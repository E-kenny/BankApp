using System.Text.Json;
using BankAppWinforms.Repositories.Interfaces;
using BankAppWinForms.Data.Interface;
using BankAppWinForms.Model.Entities;

namespace BankAppWinForms.Repositories.Implementations
{
    public class BankAccountRepository : IBankAccountRepository
    {
        private readonly IDatabase _database;
        public BankAccountRepository(IDatabase database)
        {
            _database = database;
        }

        public void CreateAccount(BankAccount account)
        {
            var totalAccount = _database.BankAccounts.Count;
            account.Id = totalAccount + 1;
            _database.BankAccounts.Add(account);
        }

        public BankAccount GetAccountByAccountNumber(string accountNumber)
        {
            return _database.BankAccounts.Find(x => x.Number == accountNumber);
        }

        public BankAccount GetAccountById(int id)
        {
            return _database.BankAccounts.Find(x => x.Id == id);
        }

        public List<BankAccount> GetAccountsByUserId(int userId)
        {
            return _database.BankAccounts.Where(x => x.CustomerId == userId).ToList();
        }
    }
}
