

using BankAppWinForm.Models;

namespace BankAppWinForm.Repositories.Interfaces
{
    public interface IBankAccountRepository
    {
        List<BankAccount> ReadAllAccounts();
        void WriteAllAccounts(List<BankAccount> data);
    }
}
