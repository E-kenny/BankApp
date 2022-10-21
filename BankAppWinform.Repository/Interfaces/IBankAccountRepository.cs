using BankAppWinForms.Model.Entities;
using System.Security.Principal;

namespace BankAppWinforms.Repositories.Interfaces
{
    public interface IBankAccountRepository
    {
        void CreateAccount(BankAccount account);
        BankAccount GetAccountById(int id);
        List<BankAccount> GetAccountsByUserId(int userId);
        BankAccount GetAccountByAccountNumber(string accountNumber);
    }
}