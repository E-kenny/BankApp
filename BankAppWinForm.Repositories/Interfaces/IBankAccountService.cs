using BankAppWinForm.Models;


namespace BankAppWinForm.Services.Interfaces
{
    public interface IBankAccountService
    {
        BankAccount OpenAccount(Customer customer, int type, decimal initialBalance);
    }
}
